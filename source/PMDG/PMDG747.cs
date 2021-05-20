using FSUIPC;
using DavyKager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfm
{

    // Class that supports the PMDG 747-400, 800, and all other varients.
    static class PMDG747
    {

        // CDU screens.
        private static PMDG_NGX_CDU_Screen cdu0 = new PMDG_NGX_CDU_Screen(0x5400);
        private static PMDG_NGX_CDU_Screen cdu1 = new PMDG_NGX_CDU_Screen(0x5800);
        private static PMDG_NGX_CDU_Screen cdu2 = new PMDG_NGX_CDU_Screen(0x5C00);


        // Collections for the panel lights.
        
                private static Dictionary<string, Dictionary<string, Dictionary<Offset<Byte>, string>>> panelLights = new Dictionary<string, Dictionary<string, Dictionary<Offset<Byte>, string>>>()
            {
            //Overhead Maintenance
            {"Overhead Maintenance",
            new Dictionary<string, Dictionary<Offset<Byte>, string>>
            {
                // Electrical
                {"Electrical",
                    new Dictionary<Offset<Byte>, string>
                    {
                        // List of offsets.
                        {Aircraft.pmdg747.ELEC_annunGen_FIELD_OFF[0], "Gen. #1 field off"},
                        {Aircraft.pmdg747.ELEC_annunGen_FIELD_OFF[1], "Gen. #2 field off" },
                        {Aircraft.pmdg747.ELEC_annunGen_FIELD_OFF[2], "Gen. #3 field off" },
                        {Aircraft.pmdg747.ELEC_annunGen_FIELD_OFF[3], "Gen. #4 field off" },
                        {Aircraft.pmdg747.ELEC_annunAPU_FIELD_OFF[0], "APU field #1 off" },
                        {Aircraft.pmdg747.ELEC_annunAPU_FIELD_OFF[1], "APU field #2 off" },
                        {Aircraft.pmdg747.ELEC_annunSplitSystemBreaker_OPEN, "Split system breaker open" },
                    } // End offsets.
                }, // End Electrical.
                {"Flight controls",
                new Dictionary<Offset<Byte>, string>
                {
                    // Offsets.

                    {Aircraft.pmdg747.FCTL_annunTailHydVALVE_CLOSED[0], "Tail hyd. #1 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunTailHydVALVE_CLOSED[1], "Tail hyd. #2 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunTailHydVALVE_CLOSED[2], "Tail hyd. #3 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunTailHydVALVE_CLOSED[3], "Tail hyd. #4 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunWingHydVALVE_CLOSED[0], "Wing hyd. #1 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunWingHydVALVE_CLOSED[1], "Wing hyd. #2 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunWingHydVALVE_CLOSED[2], "Wing hyd. #3 valve closed" },
                    {Aircraft.pmdg747.FCTL_annunWingHydVALVE_CLOSED[3], "Wing hyd. #4 valve closed" },
                } // End offsets.
                } // End Flight controls.
            } // End Overhead maint. subpanels.
                                                }, // End Overhead Maintenance

            // Overhead panels.
            {"Overhead",
                new Dictionary<string, Dictionary<Offset<Byte>, string>>
                {

                    // IRS panel.
                    {"IRS",
new Dictionary<Offset<Byte>, string>
{

    // Offsets.
    {Aircraft.pmdg747.IRS_annunON_BAT, "IRS on battery" },
    } // End offsets.
                    }, // End IRS panel.
                    {"Electrical",
                        new Dictionary<Offset<Byte>, string>
                        {
                            // offsets.
                            {Aircraft.pmdg747.ELEC_annunUtilOFF[0], "Util. #1 off" },
                            {Aircraft.pmdg747.ELEC_annunUtilOFF[1], "Util. #2 off" },
                            {Aircraft.pmdg747.ELEC_annunBusTieISLN[0], "Bus tie ISSN #1" },
                            {Aircraft.pmdg747.ELEC_annunBusTieISLN[1], "Bus tie ISSN #2" },
                            {Aircraft.pmdg747.ELEC_annunBusTieISLN[2], "Bus tie ISSN #3" },
                            {Aircraft.pmdg747.ELEC_annunBusTieISLN[3], "Bus tie ISSN #4" },
                            {Aircraft.pmdg747.ELEC_annunExtPowr_ON[0], "Ext pwr #1 on" },
                            {Aircraft.pmdg747.ELEC_annunExtPowr_ON[1], "Ext pwr #2 on" },
                            {Aircraft.pmdg747.ELEC_annunExtPowr_AVAI[0], "Ext. pwr #1 avail." },
                            {Aircraft.pmdg747.ELEC_annunExtPowr_AVAI[1], "Ext. pwr #2 avail." },
                            {Aircraft.pmdg747.ELEC_annunAPUGen_ON[0], "APU gen. #1 on" },
                            {Aircraft.pmdg747.ELEC_annunAPUGen_ON[1], "APU gen. #2 on" },
                            {Aircraft.pmdg747.ELEC_annunAPUGen_AVAIL[0], "APU gen. #1 avail." },
                            {Aircraft.pmdg747.ELEC_annunAPUGen_AVAIL[1], "APU gen. #2 avail." },
                            {Aircraft.pmdg747.ELEC_annunGenOFF[0], "Gen. #1 off" },
                            {Aircraft.pmdg747.ELEC_annunGenOFF[1], "Gen. #2 off" },
                            {Aircraft.pmdg747.ELEC_annunGenOFF[2], "Gen. #3 off" },
                            {Aircraft.pmdg747.ELEC_annunGenOFF[3], "Gen. #4 off" },
                            {Aircraft.pmdg747.ELEC_annunIDGDiscDRIVE[0], "IDG #1 disc" },
                            {Aircraft.pmdg747.ELEC_annunIDGDiscDRIVE[1], "IDG #2 disc" },
                            {Aircraft.pmdg747.ELEC_annunIDGDiscDRIVE[2], "IDG #3 disc" },
                            {Aircraft.pmdg747.ELEC_annunIDGDiscDRIVE[3], "IDG #4 disc" },
                        } // End offsets.
                    }, // End electrical.

                    // Hydraulics
                    {"Hydraulics",
new Dictionary<Offset<Byte>, string>
{
    // offsets.
    {Aircraft.pmdg747.HYD_annunSYS_FAULT[0], "System fault #1" },
    {Aircraft.pmdg747.HYD_annunSYS_FAULT[1], "System fault #2" },
    {Aircraft.pmdg747.HYD_annunSYS_FAULT[2], "System fault #3" },
    {Aircraft.pmdg747.HYD_annunSYS_FAULT[3], "System fault #4" },
    {Aircraft.pmdg747.HYD_annunEnginePumpPRESS[0], "Eng pump #1 pressure" },
    {Aircraft.pmdg747.HYD_annunEnginePumpPRESS[1], "Eng. pump #2 pressure" },
    {Aircraft.pmdg747.HYD_annunEnginePumpPRESS[2], "Eng. pump #3 pressure" },
    {Aircraft.pmdg747.HYD_annunEnginePumpPRESS[3], "Eng. pump #4 pressure" },
    {Aircraft.pmdg747.HYD_annunDemandPumpPRESS[0], "Demand pump #1 pressure" },
    {Aircraft.pmdg747.HYD_annunDemandPumpPRESS[1], "Demand pump #2 pressure" },
    {Aircraft.pmdg747.HYD_annunDemandPumpPRESS[2], "Demand pump #3 pressure" },
    {Aircraft.pmdg747.HYD_annunDemandPumpPRESS[3], "Demand pump #4 pressure" },
    {Aircraft.pmdg747.HYD_annunRamAirTurbinePRESS, "Ram air turbine pressure" }, // 748 only.
    {Aircraft.pmdg747.HYD_annunRamAirTurbineUNLKD, "Ram air turbine UNLKD" }, // 748 only.
 } // End offsets.
                    }, // End Hydraulics.

                    {"Fire protection",
                        new Dictionary<Offset<Byte>, string>
                        {

                            // Offsets.
                            {Aircraft.pmdg747.FIRE_annunENG_BTL_DISCH[0], "BTL A left" },
                            {Aircraft.pmdg747.FIRE_annunENG_BTL_DISCH[1], "BTl B left" },
                            {Aircraft.pmdg747.FIRE_annunENG_BTL_DISCH[2], "BTL A right" },
                            {Aircraft.pmdg747.FIRE_annunENG_BTL_DISCH[3], "BTL B right" },
                            {Aircraft.pmdg747.FIRE_annunCargoFire[0], "FWD fire" }, // freighters only.
                            {Aircraft.pmdg747.FIRE_annunCargoFire[1], "AFT fire" }, // Freighters only.
                            {Aircraft.pmdg747.FIRE_annunMainDeckFire, "Main deck fire" }, // Freighters only.
                            {Aircraft.pmdg747.FIRE_annunCargoDISCH, "Cargo fire discharge" },
                            {Aircraft.pmdg747.FIRE_annunAPU_BTL_DISCH, "APU fire BTL" },
                                                    } // End offsets.
                                        }, // End Fire protection.

                    {"Engine control",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.ENG_Start_Light[00], "Engine #1 start" },
                            {Aircraft.pmdg747.ENG_Start_Light[1], "Engine #2 start" },
                            {Aircraft.pmdg747.ENG_Start_Light[2], "Engine #3 start" },
                            {Aircraft.pmdg747.ENG_Start_Light[3], "Engine #3 start" },
                            {Aircraft.pmdg747.ENG_annunALTN[0], "Engine #1 ALTN" },
                            {Aircraft.pmdg747.ENG_annunALTN[1], "Engine #2 ALTN" },
                            {Aircraft.pmdg747.ENG_annunALTN[2], "Engine #3 ALTN" },
                            {Aircraft.pmdg747.ENG_annunALTN[3], "Engine #4 ALTN" },
                        } // End offsets.
                    }, // End engine control.

                    {"Fuel",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.FUEL_annunXFEED_VALVE[0], "Cross feed valve #1" },
                            {Aircraft.pmdg747.FUEL_annunXFEED_VALVE[1], "Cross feed valve #2" },
                            {Aircraft.pmdg747.FUEL_annunXFEED_VALVE[2], "Cross feed valve #3" },
                            {Aircraft.pmdg747.FUEL_annunXFEED_VALVE[3], "Cross feed valve #4" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainFwd[0], "Main FWD #1 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainFwd[1], "Main FWD #2 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainFwd[2], "Main FWD #3 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainFwd[3], "Main FWD #4 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainAft[0], "Main AFT #1 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainAft[1], "Main AFT #2 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainAft[2], "Main AFT #3 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_MainAft[3], "Main AFT #4 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_OvrdFwd[0], "OVRD FWD 2 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_OvrdFwd[1], "OVRD FWD 3 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_OvrdAft[0], "OVRD AFT 2 pressure" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_OvrdAft[1], "OVRD AFT 3 pressure" },{Aircraft.pmdg747.FUEL_annunPRESS_Stab[0], "Pressure stabalizer, left" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_Stab[1], "Pressure stabalizer, right" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_Ctr[0], "Center pressure, left" },
                            {Aircraft.pmdg747.FUEL_annunPRESS_Ctr[1], "Center pressure, right" },
                            {Aircraft.pmdg747.FUEL_annunJettisonNozleVALVE[0], "Jettison nozel valve, left" },
                            {Aircraft.pmdg747.FUEL_annunJettisonNozleVALVE[1], "Jettison nozel valve, right" },
                        } // End offsets.
                                        }, // End Fuel.
                    {"Anti ice",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.ICE_annunEngAntiIceVALVE[0], "Eng. #1 Anti ice valve" },
                            {Aircraft.pmdg747.ICE_annunEngAntiIceVALVE[1], "Eng. #2 anti ice valve" },
                            {Aircraft.pmdg747.ICE_annunEngAntiIceVALVE[2], "Eng. #3 anti ice valve" },
                            {Aircraft.pmdg747.ICE_annunEngAntiIceVALVE[3], "Eng. #4 anti ice valve" },
                            {Aircraft.pmdg747.ICE_annunWingAntiIceVALVE, "Wing ainti ice valve" },
                            {Aircraft.pmdg747.ICE_annunWindowHeatINOP[0], "Left window heat" },
                            {Aircraft.pmdg747.ICE_annunWindowHeatINOP[1], "Right window heat" },
                        } // End offsets.
                                        }, //End Anti ice.
                    {"Air conditioning",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.AIR_annunPackOFF[0], "Left pack off" },
                            {Aircraft.pmdg747.AIR_annunPackOFF[1], "Center pack off" },
                            {Aircraft.pmdg747.AIR_annunPackOFF[2], "Right pack off" },
                            {Aircraft.pmdg747.AIR_annunPack_SYS_FAIL, "Pack system failure" },
                            {Aircraft.pmdg747.AIR_annunZone_SYS_FAIL, "Zone system failure" },
                            {Aircraft.pmdg747.AIR_annunAftCragoHeat_TEMP, "Aft cargo heat temp" },
                                                    } // End offsets.
                    }, // End air conditioning.
                    {"Bleed air",
                    new Dictionary<Offset<Byte>, string>
                    {
                        {Aircraft.pmdg747.AIR_annunEngBleedAirOFF[0], "Eng. #1 bleed air off" },
                        {Aircraft.pmdg747.AIR_annunEngBleedAirOFF[1], "Eng. #2 bleed air off" },
                        {Aircraft.pmdg747.AIR_annunEngBleedAirOFF[2], "Eng. #3 bleed air off" },
                        {Aircraft.pmdg747.AIR_annunEngBleedAirOFF[3], "Eng. #4 bleed air off" },
                        {Aircraft.pmdg747.AIR_annunAPUBleedAirVALVE, "APU bleed air valve" },
                        {Aircraft.pmdg747.AIR_annunIsolationVALVE[0], "Left isolation valve" },
                        {Aircraft.pmdg747.AIR_annunIsolationVALVE[1], "Right isolation valve" },
                        {Aircraft.pmdg747.AIR_annun_SYS_FAULT[0], "Air system #1 fault" },
                        {Aircraft.pmdg747.AIR_annun_SYS_FAULT[1], "Air system #2 fault" },
                        {Aircraft.pmdg747.AIR_annun_SYS_FAULT[2], "Air system #3 fault" },
                        {Aircraft.pmdg747.AIR_annun_SYS_FAULT[3], "Air system #4 fault" },
                                            } // End offsets.
                    }, // End air bleed.
                    {"Miscellaneous",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.FCTL_annunYawDamperINOP[0], "Upper yaw damper inop" },
                            {Aircraft.pmdg747.FCTL_annunYawDamperINOP[1], "Lower yaw damper inop" },
                        } // End offsets.
                                        }, // End Miscellaneous
                } // End Overhead subpanels.
            }, // End Overhead panels.
            {"Glare shield",
                new Dictionary<string, Dictionary<Offset<Byte>, string>>
                {
                    {"Warnings",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.WARN_annunMASTER_CAUTION[0], "Left master caution" },
                            {Aircraft.pmdg747.WARN_annunMASTER_CAUTION[1], "Right master caution" },
                            {Aircraft.pmdg747.WARN_annunMASTER_WARNING[0], "Right master warning" },
                            {Aircraft.pmdg747.WARN_annunMASTER_WARNING[1], "Right master warning" },
                        } // End offsets.
                }, // End warnings.
                    {"Display select",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.DSP_annunLWR_CTR, "WR Ctr" },
                            {Aircraft.pmdg747.DSP_annunL_INBD, "LNIBD" },
                            {Aircraft.pmdg747.DSP_annunR_INBD, "RNIBD" },
                        } // End offsets.
                    }, // End display select.
                    {"MCP",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.MCP_annunAP[0], "Left Autopilot" },
                            {Aircraft.pmdg747.MCP_annunAP[1], "Center Autopilot" },
                            {Aircraft.pmdg747.MCP_annunAP[2], "Right Autopilot" },
                            {Aircraft.pmdg747.MCP_annunTHR, "Thrust" },
                            {Aircraft.pmdg747.MCP_annunSPD, "Speed" },
                            {Aircraft.pmdg747.MCP_annunLNAV, "L NAV" },
                            {Aircraft.pmdg747.MCP_annunVNAV, "V NAV" },
                            {Aircraft.pmdg747.MCP_annunFLCH, "Flight level change" },
                            {Aircraft.pmdg747.MCP_annunHDG_HOLD, "Heading hold" },
                            {Aircraft.pmdg747.MCP_annunVS, "Vertical speed" },
                            {Aircraft.pmdg747.MCP_annunALT_HOLD, "Altitude hold" },
                            {Aircraft.pmdg747.MCP_annunLOC, "Localizer" },
                            {Aircraft.pmdg747.MCP_annunAPP, "Approach" },
                        } // End offsets.
                    }, // End MCP
                               } // End glare shield panels.
                }, // End Glareshield.
            {"Forward",
                new Dictionary<string, Dictionary<Offset<Byte>, string>>
                {
                    {"Center",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.GPWS_annunGND_PROX_top, "Ground prox. top" },
                            {Aircraft.pmdg747.GPWS_annunGND_PROX_bottom, "Ground prox. bottom" },
                        } // End offsets.
                    }, // End Center panel.
                    {"Left",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.BRAKES_annunBRAKE_SOURCE, "Break source" },
                        } // End offsets.
                    }, // End Left.
                                    } // End forward sub panels.
            }, // End Forward panel.
            {"Forward Aisle Stand",
                new Dictionary<string, Dictionary<Offset<Byte>, string>>
                {
                    {"CDU",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.CDU_annunEXEC[0], "Left CDU execute" },
                            {Aircraft.pmdg747.CDU_annunEXEC[1], "Center CDU execute" },
                            {Aircraft.pmdg747.CDU_annunEXEC[2], "Right CDU execute" },
                            {Aircraft.pmdg747.CDU_annunDSPY[0], "Left CDU display" },
                            {Aircraft.pmdg747.CDU_annunDSPY[1], "Center CDU display" },
                            {Aircraft.pmdg747.CDU_annunDSPY[2], "Right CDU display" },
                            {Aircraft.pmdg747.CDU_annunFAIL[0], "Left CDU fail" },
                            {Aircraft.pmdg747.CDU_annunFAIL[1], "Center CDU fail" },
                            {Aircraft.pmdg747.CDU_annunFAIL[2], "Right CDU fail" },
                            {Aircraft.pmdg747.CDU_annunMSG[0], "Left CDU message" },
                            {Aircraft.pmdg747.CDU_annunMSG[1], "Center CDU message" },
                            {Aircraft.pmdg747.CDU_annunMSG[2], "Right CDU message" },
                            {Aircraft.pmdg747.CDU_annunOFST[0], "Left CDU offset" },
                            {Aircraft.pmdg747.CDU_annunOFST[1], "Center CDU offset" },
                            {Aircraft.pmdg747.CDU_annunOFST[2], "Right CDU offset" },
                                                    } // End offsets.
                    }, // End CDU
                } // End Forward Aisle Stand sub panels.
                            }, // End Forward Aisle Stand
            {"Aft Aisle Stand",
                new Dictionary<string, Dictionary<Offset<Byte>, string>>
                {
                    {"radio",
                        new Dictionary<Offset<Byte>, string>
                        {
                            {Aircraft.pmdg747.COMM_annunAM[0], "Left AM" },
                            {Aircraft.pmdg747.COMM_annunAM[1], "Center AM" },
                            {Aircraft.pmdg747.COMM_annunAM[2], "Right AM" },
                        } // End offsets.
                    }, // End audio comms
                } // End Aft Aisle Stand sub panels.
            }, // End Aft Aisle Stand
        };
        public static Dictionary<string, Dictionary<string, Dictionary<Offset<byte>, string>>> Lights
        {
            get => panelLights;
                                
                        } // End Lights.
        
              
        } // End PMDG747
} // End Namespace
