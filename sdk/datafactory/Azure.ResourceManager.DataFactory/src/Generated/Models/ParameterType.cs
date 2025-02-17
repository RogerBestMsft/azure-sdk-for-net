// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Parameter type. </summary>
    public readonly partial struct ParameterType : IEquatable<ParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ObjectValue = "Object";
        private const string StringValue = "String";
        private const string IntValue = "Int";
        private const string FloatValue = "Float";
        private const string BoolValue = "Bool";
        private const string ArrayValue = "Array";
        private const string SecureStringValue = "SecureString";

        /// <summary> Object. </summary>
        public static ParameterType Object { get; } = new ParameterType(ObjectValue);
        /// <summary> String. </summary>
        public static ParameterType String { get; } = new ParameterType(StringValue);
        /// <summary> Int. </summary>
        public static ParameterType Int { get; } = new ParameterType(IntValue);
        /// <summary> Float. </summary>
        public static ParameterType Float { get; } = new ParameterType(FloatValue);
        /// <summary> Bool. </summary>
        public static ParameterType Bool { get; } = new ParameterType(BoolValue);
        /// <summary> Array. </summary>
        public static ParameterType Array { get; } = new ParameterType(ArrayValue);
        /// <summary> SecureString. </summary>
        public static ParameterType SecureString { get; } = new ParameterType(SecureStringValue);
        /// <summary> Determines if two <see cref="ParameterType"/> values are the same. </summary>
        public static bool operator ==(ParameterType left, ParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ParameterType"/> values are not the same. </summary>
        public static bool operator !=(ParameterType left, ParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ParameterType"/>. </summary>
        public static implicit operator ParameterType(string value) => new ParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
