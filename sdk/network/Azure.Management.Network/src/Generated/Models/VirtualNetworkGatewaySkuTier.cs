// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Gateway SKU tier. </summary>
    public readonly partial struct VirtualNetworkGatewaySkuTier : IEquatable<VirtualNetworkGatewaySkuTier>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuTier"/> values are the same. </summary>
        public VirtualNetworkGatewaySkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string HighPerformanceValue = "HighPerformance";
        private const string StandardValue = "Standard";
        private const string UltraPerformanceValue = "UltraPerformance";
        private const string VpnGw1Value = "VpnGw1";
        private const string VpnGw2Value = "VpnGw2";
        private const string VpnGw3Value = "VpnGw3";
        private const string VpnGw4Value = "VpnGw4";
        private const string VpnGw5Value = "VpnGw5";
        private const string VpnGw1AZValue = "VpnGw1AZ";
        private const string VpnGw2AZValue = "VpnGw2AZ";
        private const string VpnGw3AZValue = "VpnGw3AZ";
        private const string VpnGw4AZValue = "VpnGw4AZ";
        private const string VpnGw5AZValue = "VpnGw5AZ";
        private const string ErGw1AZValue = "ErGw1AZ";
        private const string ErGw2AZValue = "ErGw2AZ";
        private const string ErGw3AZValue = "ErGw3AZ";

        /// <summary> Basic. </summary>
        public static VirtualNetworkGatewaySkuTier Basic { get; } = new VirtualNetworkGatewaySkuTier(BasicValue);
        /// <summary> HighPerformance. </summary>
        public static VirtualNetworkGatewaySkuTier HighPerformance { get; } = new VirtualNetworkGatewaySkuTier(HighPerformanceValue);
        /// <summary> Standard. </summary>
        public static VirtualNetworkGatewaySkuTier Standard { get; } = new VirtualNetworkGatewaySkuTier(StandardValue);
        /// <summary> UltraPerformance. </summary>
        public static VirtualNetworkGatewaySkuTier UltraPerformance { get; } = new VirtualNetworkGatewaySkuTier(UltraPerformanceValue);
        /// <summary> VpnGw1. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw1 { get; } = new VirtualNetworkGatewaySkuTier(VpnGw1Value);
        /// <summary> VpnGw2. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw2 { get; } = new VirtualNetworkGatewaySkuTier(VpnGw2Value);
        /// <summary> VpnGw3. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw3 { get; } = new VirtualNetworkGatewaySkuTier(VpnGw3Value);
        /// <summary> VpnGw4. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw4 { get; } = new VirtualNetworkGatewaySkuTier(VpnGw4Value);
        /// <summary> VpnGw5. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw5 { get; } = new VirtualNetworkGatewaySkuTier(VpnGw5Value);
        /// <summary> VpnGw1AZ. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw1AZ { get; } = new VirtualNetworkGatewaySkuTier(VpnGw1AZValue);
        /// <summary> VpnGw2AZ. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw2AZ { get; } = new VirtualNetworkGatewaySkuTier(VpnGw2AZValue);
        /// <summary> VpnGw3AZ. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw3AZ { get; } = new VirtualNetworkGatewaySkuTier(VpnGw3AZValue);
        /// <summary> VpnGw4AZ. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw4AZ { get; } = new VirtualNetworkGatewaySkuTier(VpnGw4AZValue);
        /// <summary> VpnGw5AZ. </summary>
        public static VirtualNetworkGatewaySkuTier VpnGw5AZ { get; } = new VirtualNetworkGatewaySkuTier(VpnGw5AZValue);
        /// <summary> ErGw1AZ. </summary>
        public static VirtualNetworkGatewaySkuTier ErGw1AZ { get; } = new VirtualNetworkGatewaySkuTier(ErGw1AZValue);
        /// <summary> ErGw2AZ. </summary>
        public static VirtualNetworkGatewaySkuTier ErGw2AZ { get; } = new VirtualNetworkGatewaySkuTier(ErGw2AZValue);
        /// <summary> ErGw3AZ. </summary>
        public static VirtualNetworkGatewaySkuTier ErGw3AZ { get; } = new VirtualNetworkGatewaySkuTier(ErGw3AZValue);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuTier"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkGatewaySkuTier left, VirtualNetworkGatewaySkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewaySkuTier"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkGatewaySkuTier left, VirtualNetworkGatewaySkuTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkGatewaySkuTier"/>. </summary>
        public static implicit operator VirtualNetworkGatewaySkuTier(string value) => new VirtualNetworkGatewaySkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkGatewaySkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkGatewaySkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}