﻿using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Chromely.Mvc
{
    public interface IModelBinder
    {
        object BindToArray(Type arrayType, object value);
        object BindToModel(Type type, object value);
        object BindToModel(Type type, JsonElement value);
        object BindToModel(Type type, IDictionary<string, object> value);
        object GetBoundValue(Type type, string name, IDictionary<string, object> valueLookup);
    }
}