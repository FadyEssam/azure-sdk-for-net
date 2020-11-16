// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    /// <summary> The type of interpolation technique : &quot;Linear&quot; or &quot;Step&quot;. </summary>
    public readonly partial struct InterpolationKind : IEquatable<InterpolationKind>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="InterpolationKind"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InterpolationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinearValue = "Linear";
        private const string StepValue = "Step";

        /// <summary> Linear. </summary>
        public static InterpolationKind Linear { get; } = new InterpolationKind(LinearValue);
        /// <summary> Step. </summary>
        public static InterpolationKind Step { get; } = new InterpolationKind(StepValue);
        /// <summary> Determines if two <see cref="InterpolationKind"/> values are the same. </summary>
        public static bool operator ==(InterpolationKind left, InterpolationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InterpolationKind"/> values are not the same. </summary>
        public static bool operator !=(InterpolationKind left, InterpolationKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InterpolationKind"/>. </summary>
        public static implicit operator InterpolationKind(string value) => new InterpolationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InterpolationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InterpolationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}