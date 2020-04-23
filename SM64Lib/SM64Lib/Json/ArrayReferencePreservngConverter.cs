﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SM64Lib.Json
{
    public class ArrayReferencePreservngConverter : JsonConverter
    {
        const string refProperty = "$ref";
        const string idProperty = "$id";
        const string valuesProperty = "$values";

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            else if (reader.TokenType == JsonToken.StartArray)
            {
                // No $ref.  Deserialize as a List<T> to avoid infinite recursion and return as an array.
                var elementType = objectType.GetElementType();
                var listType = typeof(List<>).MakeGenericType(elementType);
                var list = (IList)serializer.Deserialize(reader, listType);
                if (list == null)
                    return null;
                var array = Array.CreateInstance(elementType, list.Count);
                list.CopyTo(array, 0);
                return array;
            }
            else
            {
                var obj = JObject.Load(reader);
                var refId = (string)obj[refProperty];
                if (refId != null)
                {
                    var reference = serializer.ReferenceResolver.ResolveReference(serializer, refId);
                    if (reference != null)
                        return reference;
                }
                var values = obj[valuesProperty];
                if (values == null || values.Type == JTokenType.Null)
                    return null;
                if (!(values is JArray))
                {
                    throw new JsonSerializationException(string.Format("{0} was not an array", values));
                }
                var count = ((JArray)values).Count;

                var elementType = objectType.GetElementType();
                var array = Array.CreateInstance(elementType, count);

                var objId = (string)obj[idProperty];
                if (objId != null)
                {
                    // Add the empty array into the reference table BEFORE poppulating it,
                    // to handle recursive references.
                    serializer.ReferenceResolver.AddReference(serializer, objId, array);
                }

                var listType = typeof(List<>).MakeGenericType(elementType);
                using (var subReader = values.CreateReader())
                {
                    var list = (IList)serializer.Deserialize(subReader, listType);
                    list.CopyTo(array, 0);
                }

                return array;
            }
        }

        public override bool CanWrite { get { return false; } }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
