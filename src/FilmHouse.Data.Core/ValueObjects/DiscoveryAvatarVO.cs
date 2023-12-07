﻿#nullable enable
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using FilmHouse.Core.Utils.Data;
using FilmHouse.Core.ValueObjects.Serialization;
using FilmHouse.Data.Core.ValueObjects;
using FilmHouse.Core.ValueObjects;

namespace FilmHouse.Data.Core.ValueObjects
{
    /// <summary>
    /// 电影每日发现专栏图片地址（100位文本）的值对象类。
    /// </summary>
    [JsonConverter(typeof(DiscoveryAvatarVOJsonConverter))]
    [ValueConverter(typeof(DiscoveryAvatarVOValueConverter), typeof(DiscoveryAvatarVOArrayValueConverter))]
    [System.ComponentModel.TypeConverter(typeof(DiscoveryAvatarVOTypeConverter))]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.Runtime.CompilerServices.CompilerGenerated]
    public partial class DiscoveryAvatarVO : FilmHouse.Core.ValueObjects.TextBase, IEquatable<DiscoveryAvatarVO>, IComparable<DiscoveryAvatarVO>, IValue<string>, IValueObject
    {
        private readonly string _value;

        /// <summary>
        /// 取得型名。
        /// </summary>
        public new const string TypeName = "DiscoveryAvatar(size:100)";

        /// <summary>
        /// 取得位数。
        /// </summary>
        public const int Size = 100;

        /// <summary>
        /// <see cref="DiscoveryAvatarVO"/>的新实例。
        /// </summary>
        /// <param name="value">值对象包含的原始类型</param>
        public DiscoveryAvatarVO(string value)
            : base(value)
        {
            this.PreProcess(ref value);
            this._value = value;
            this.Validate();
        }

        partial void PreProcess(ref string value);

        partial void Validate();

        /// <summary>
        /// <see cref="string"/>向<see cref="DiscoveryAvatarVO"/>进行隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator string(DiscoveryAvatarVO value)
        {
            return value._value;
        }

        /// <summary>
        /// <see cref="DiscoveryAvatarVO"/>向<see cref="string"/>进行隐式转换
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator DiscoveryAvatarVO(string value)
        {
            return new DiscoveryAvatarVO(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        internal static bool Equals(in DiscoveryAvatarVO? x, in DiscoveryAvatarVO? y)
        {
            if (x is null && y is null)
            {
                return true;
            }
            if ((x is not null && y is null) || (x is null && y is not null))
            {
                return false;
            }
            return x!._value.Equals(y!._value);
        }

        /// <summary>
        /// <see cref="string"/>对句式和包含的原始句式进行比较处理。
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(DiscoveryAvatarVO? other)
        {
            return Equals(this, other);
        }

        /// <summary>
        /// 判断对象之间是否一致。
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            var t = obj.GetType();
            if (typeof(DiscoveryAvatarVO).IsAssignableFrom(t))
            {
                return Equals((DiscoveryAvatarVO)obj);
            }
            if (t == typeof(string))
            {
                return this._value.Equals((string)obj);
            }

            return this._value.Equals(obj);
        }

        /// <summary>
        /// 作为既定的散列函数发挥作用。
        /// </summary>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// 返回表示当前对象的字符串。
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}", this._value);
        }



        /// <summary>
        /// 是否等于
        /// </summary>
        public static bool operator ==(in DiscoveryAvatarVO? x, in DiscoveryAvatarVO? y)
        {
            return Equals(x, y);
        }

        /// <summary>
        /// 是否不相等
        /// </summary>
        public static bool operator !=(in DiscoveryAvatarVO? x, in DiscoveryAvatarVO? y)
        {
            return !Equals(x, y);
        }






        // UnitGenerateOptions.ComparableInterfaceOnly

        /// <summary>
        /// 将该实例<paramref name="other" />和比较。
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(DiscoveryAvatarVO? other)
        {
            if (other == null)
            {
                return 1;
            }
            return this._value.CompareTo(other._value);
        }


        // UnitGenerateOptions.JsonConverter
        private class DiscoveryAvatarVOJsonConverter : JsonConverter<DiscoveryAvatarVO>
        {
            public override void Write(Utf8JsonWriter writer, DiscoveryAvatarVO value, JsonSerializerOptions options)
            {
                var converter = options.GetConverter(typeof(string)) as JsonConverter<string>;
                if (converter != null)
                {
                    converter.Write(writer, value._value.Replace("\r\n", "\n"), options);
                }
                else
                {
                    throw new JsonException($"{typeof(string)} converter does not found.");
                }
            }

            public override DiscoveryAvatarVO? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var converter = options.GetConverter(typeof(string)) as JsonConverter<string>;
                if (converter != null)
                {
                    try
                    {
                        var value = converter.Read(ref reader, typeToConvert, options);
                        return value != null ? new DiscoveryAvatarVO(value.Replace("\r\n", "\n")) : null;
                    }
                    catch (Exception exception)
                    {
                        throw options.GetInvalidValueException(ref reader, typeof(string), exception);
                    }
                }
                else
                {
                    throw options.GetConvertFailureException(typeToConvert);
                }
            }
        }




        // UnitGenerateOptions.EntityFrameworkValueConverter
        /// <summary>
        /// EntityFrameworkCore和值对象进行相互转换的转换器类。
        /// </summary>
        public class DiscoveryAvatarVOValueConverter : Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<DiscoveryAvatarVO?, string?>
        {
            /// <summary>
            /// <see cref="DiscoveryAvatarVOValueConverter"/>的新实例。
            /// </summary>
            public DiscoveryAvatarVOValueConverter()
                : this(null)
            {
            }

            /// <summary>
            /// <see cref="DiscoveryAvatarVOValueConverter"/>的新实例。
            /// </summary>
            /// <param name="mappingHints"></param>
            public DiscoveryAvatarVOValueConverter(Microsoft.EntityFrameworkCore.Storage.ValueConversion.ConverterMappingHints? mappingHints = null)
                : base(
                        convertToProviderExpression: x => x != null ? x._value : null,
                        convertFromProviderExpression: x => x != null ? new DiscoveryAvatarVO(x) : null,
                        mappingHints: mappingHints)
            {
            }

            /// <summary>
            /// 当将数据写入存储时，获取转换对象的函数，设置为处理空、装箱和非严格匹配的简单类型匹配。
            /// </summary>
            public override Func<object?, object?> ConvertToProvider => (x) => x switch
            {
                string value => value,
                DiscoveryAvatarVO value => value._value,
                _ => null,
            };

            /// <summary>
            /// 当从存储中读取数据时，获取转换对象的函数。该函数设置为处理空、装箱和非严格匹配的简单类型的匹配。
            /// </summary>
            public override Func<object?, object?> ConvertFromProvider => (x) => x switch
            {
                DiscoveryAvatarVO value => value,
                string value => new DiscoveryAvatarVO(value),
                _ => null,
            };
        }

        /// <summary>
        /// EntityFrameworkCore和值对象进行相互转换的转换器类。
        /// </summary>
        public class DiscoveryAvatarVOArrayValueConverter : Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<DiscoveryAvatarVO?[], string?[]>
        {
            /// <summary>
            /// <see cref="DiscoveryAvatarVOArrayValueConverter"/>的新实例。
            /// </summary>
            public DiscoveryAvatarVOArrayValueConverter()
                : this(null)
            {
            }

            /// <summary>
            /// <see cref="DiscoveryAvatarVOArrayValueConverter"/>的新实例。
            /// </summary>
            /// <param name="mappingHints"></param>
            public DiscoveryAvatarVOArrayValueConverter(Microsoft.EntityFrameworkCore.Storage.ValueConversion.ConverterMappingHints? mappingHints = null)
                : base(
                        convertToProviderExpression: x => x.Select(_ => _ == null ? (string?)null : _._value).ToArray(),
                        convertFromProviderExpression: x => x.Select(_ => _ == null ? null : new DiscoveryAvatarVO(_)).ToArray(),
                        mappingHints: mappingHints)
            {
            }

            /// <summary>
            /// 当将数据写入存储时，获取转换对象的函数，设置为处理空、装箱和非严格匹配的简单类型匹配。
            /// </summary>
            public override Func<object?, object?> ConvertToProvider => (x) => x switch
            {
                string?[] values => values,
                DiscoveryAvatarVO?[] values => values.Select(_ => _?._value).ToArray(),
                IEnumerable<string?> values => values.ToArray(),
                IEnumerable<DiscoveryAvatarVO?> values => values.Select(_ => _?._value).ToArray(),
                _ => null,
            };

            /// <summary>
            /// 当从存储中读取数据时，获取转换对象的函数。该函数设置为处理空、装箱和非严格匹配的简单类型的匹配。
            /// </summary>
            public override Func<object?, object?> ConvertFromProvider => (x) => x switch
            {
                DiscoveryAvatarVO?[] values => values,
                string?[] values => values.Select(_ => _ == null ? null : new DiscoveryAvatarVO(_)).ToArray(),
                IEnumerable<DiscoveryAvatarVO?> values => values.ToArray(),
                IEnumerable<string?> values => values.Select(_ => _ == null ? null : new DiscoveryAvatarVO(_)).ToArray(),
                _ => null,
            };
        }

        // Default
        private class DiscoveryAvatarVOTypeConverter : System.ComponentModel.TypeConverter
        {
            private static readonly Type WrapperType = typeof(DiscoveryAvatarVO);
            private static readonly Type ValueType = typeof(string);
            private static readonly Type BindingValueType = typeof(string);

            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext? context, Type sourceType)
            {
                if (sourceType == WrapperType || sourceType == ValueType || sourceType == BindingValueType)
                {
                    return true;
                }

                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext? context, Type? destinationType)
            {
                if (destinationType != null)
                {
                    if (destinationType == WrapperType || destinationType == ValueType || destinationType == BindingValueType)
                    {
                        return true;
                    }
                }

                return base.CanConvertTo(context, destinationType);
            }

            public override object? ConvertFrom(System.ComponentModel.ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object value)
            {
                var t = value.GetType();
                if (t == typeof(DiscoveryAvatarVO))
                {
                    return (DiscoveryAvatarVO)value;
                }
                if (t == typeof(string))
                {
                    return new DiscoveryAvatarVO((string)value);
                }

                return base.ConvertFrom(context, culture, value);
            }

            public override object? ConvertTo(System.ComponentModel.ITypeDescriptorContext? context, System.Globalization.CultureInfo? culture, object? value, Type destinationType)
            {
                if (value == null)
                {
                    return null;
                }

                if (value is DiscoveryAvatarVO wrappedValue)
                {
                    if (destinationType == WrapperType)
                    {
                        return wrappedValue;
                    }

                    if (destinationType == ValueType)
                    {
                        return wrappedValue.AsPrimitive();
                    }

                    if (destinationType == BindingValueType)
                    {
                        return $"{wrappedValue.AsPrimitive()}";
                    }
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
    }
}
