﻿using System.Reflection;

using Newtonsoft.Json.Serialization;

namespace SoundCloud.Api.Json
{
    public class NullIntValueProvider : IValueProvider
    {
        private readonly IValueProvider _underlyingValueProvider;

        public NullIntValueProvider(MemberInfo memberInfo)
        {
            _underlyingValueProvider = new DynamicValueProvider(memberInfo);
        }

        public object GetValue(object target) => _underlyingValueProvider.GetValue(target) ?? 0;

        public void SetValue(object target, object value)
        {
            _underlyingValueProvider.SetValue(target, value ?? 0);
        }
    }
}