// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Administration.Models
{
    /// <summary> The assignment status of the phone number. Conveys what type of entity the number is assigned to. </summary>
    public readonly partial struct AssignmentStatus : IEquatable<AssignmentStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AssignmentStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssignmentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnassignedValue = "Unassigned";
        private const string UnknownValue = "Unknown";
        private const string UserAssignedValue = "UserAssigned";
        private const string ConferenceAssignedValue = "ConferenceAssigned";
        private const string FirstPartyAppAssignedValue = "FirstPartyAppAssigned";
        private const string ThirdPartyAppAssignedValue = "ThirdPartyAppAssigned";

        /// <summary> Unassigned. </summary>
        public static AssignmentStatus Unassigned { get; } = new AssignmentStatus(UnassignedValue);
        /// <summary> Unknown. </summary>
        public static AssignmentStatus Unknown { get; } = new AssignmentStatus(UnknownValue);
        /// <summary> UserAssigned. </summary>
        public static AssignmentStatus UserAssigned { get; } = new AssignmentStatus(UserAssignedValue);
        /// <summary> ConferenceAssigned. </summary>
        public static AssignmentStatus ConferenceAssigned { get; } = new AssignmentStatus(ConferenceAssignedValue);
        /// <summary> FirstPartyAppAssigned. </summary>
        public static AssignmentStatus FirstPartyAppAssigned { get; } = new AssignmentStatus(FirstPartyAppAssignedValue);
        /// <summary> ThirdPartyAppAssigned. </summary>
        public static AssignmentStatus ThirdPartyAppAssigned { get; } = new AssignmentStatus(ThirdPartyAppAssignedValue);
        /// <summary> Determines if two <see cref="AssignmentStatus"/> values are the same. </summary>
        public static bool operator ==(AssignmentStatus left, AssignmentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssignmentStatus"/> values are not the same. </summary>
        public static bool operator !=(AssignmentStatus left, AssignmentStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssignmentStatus"/>. </summary>
        public static implicit operator AssignmentStatus(string value) => new AssignmentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssignmentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssignmentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}