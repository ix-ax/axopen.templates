using System;
using AXSharp.Connector;
using AXSharp.Connector.ValueTypes;
using System.Collections.Generic;
using AXSharp.Connector.Localizations;

public enum HwIdentifiers : UInt16
{
    PROFINET_IO_System_HwID = 256,
    plc_line_HwID = 32,
    plc_line_Rail_0_HwID = 257,
    plc_line_plc_line_HwID = 48,
    plc_line_plc_line__plc_line_HwID = 49,
    plc_line_plc_line_CPU_display_1_HwID = 54,
    plc_line_plc_line_CPU_exec_unit_1_HwID = 52,
    plc_line_plc_line_Card_reader_writer_1_HwID = 51,
    plc_line_plc_line_DP_interface_1_HwID = 60,
    plc_line_plc_line_LicenseManager_1_HwID = 42,
    plc_line_plc_line_OPC_UA_1_HwID = 117,
    plc_line_plc_line_PROFINET_interface_2_HwID = 72,
    plc_line_plc_line_PROFINET_interface_2_Port_1_HwID = 73,
    plc_line_plc_line_Virtual_communication_interface_HwID = 135,
    plc_line_plc_line_plc_line_HwID = 50,
    plc_line_plc_line_profinet_x1_HwID = 64,
    plc_line_plc_line_profinet_x1_Port1_HwID = 65,
    plc_line_plc_line_profinet_x1_Port2_HwID = 66,
    NONE = 0
}