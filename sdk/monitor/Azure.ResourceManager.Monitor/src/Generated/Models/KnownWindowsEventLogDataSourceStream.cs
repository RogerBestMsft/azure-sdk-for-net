// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The KnownWindowsEventLogDataSourceStream. </summary>
    public readonly partial struct KnownWindowsEventLogDataSourceStream : IEquatable<KnownWindowsEventLogDataSourceStream>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownWindowsEventLogDataSourceStream"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownWindowsEventLogDataSourceStream(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftWindowsEventValue = "Microsoft-WindowsEvent";
        private const string MicrosoftEventValue = "Microsoft-Event";

        /// <summary> Microsoft-WindowsEvent. </summary>
        public static KnownWindowsEventLogDataSourceStream MicrosoftWindowsEvent { get; } = new KnownWindowsEventLogDataSourceStream(MicrosoftWindowsEventValue);
        /// <summary> Microsoft-Event. </summary>
        public static KnownWindowsEventLogDataSourceStream MicrosoftEvent { get; } = new KnownWindowsEventLogDataSourceStream(MicrosoftEventValue);
        /// <summary> Determines if two <see cref="KnownWindowsEventLogDataSourceStream"/> values are the same. </summary>
        public static bool operator ==(KnownWindowsEventLogDataSourceStream left, KnownWindowsEventLogDataSourceStream right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownWindowsEventLogDataSourceStream"/> values are not the same. </summary>
        public static bool operator !=(KnownWindowsEventLogDataSourceStream left, KnownWindowsEventLogDataSourceStream right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownWindowsEventLogDataSourceStream"/>. </summary>
        public static implicit operator KnownWindowsEventLogDataSourceStream(string value) => new KnownWindowsEventLogDataSourceStream(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownWindowsEventLogDataSourceStream other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownWindowsEventLogDataSourceStream other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
