//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IOTGatwayPacketsData
    {
        public int GatewayMsgID { get; set; }
        public string SOF { get; set; }
        public string SiteId { get; set; }
        public string UnitId { get; set; }
        public string PacketType { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string IPAddres { get; set; }
        public string ProductSerialNo { get; set; }
        public string SWversion { get; set; }
        public string NumOfNodeDetected { get; set; }
        public string NumOfNodeActive { get; set; }
        public string NodeId { get; set; }
        public string NodeCommunication { get; set; }
        public string NodePayLoadLength { get; set; }
        public string NodeDataPayLoad { get; set; }
        public string EOF { get; set; }
        public string IOTGateWayMsg { get; set; }
        public string CorrectedDate { get; set; }
        public string TypeOfDevice { get; set; }
        public string DevicePayLoadLength { get; set; }
        public Nullable<int> AlaramInput1_16 { get; set; }
        public Nullable<int> AlaramInput2_17 { get; set; }
        public Nullable<int> AlaramInput3_18 { get; set; }
        public Nullable<int> AlaramInput4_19 { get; set; }
        public Nullable<int> AlaramInput5_20 { get; set; }
        public Nullable<int> AlaramInput6_22 { get; set; }
        public Nullable<int> AlaramInput7_23 { get; set; }
        public Nullable<int> AlaramInput8_24 { get; set; }
        public string Reserved { get; set; }
        public string RelayFeedbak1Status { get; set; }
        public string RelayFeedbak2Status { get; set; }
        public string RelayFeedbak3Status { get; set; }
        public string RelayFeedbak4Status { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}