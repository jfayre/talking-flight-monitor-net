using DavyKager;
using FSUIPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tfm
{
    class pmdg
    {
        /* This class contains functions for manipulating controls in the PMDG 737. 
         * Functions were ported from the PMDG 737 Linda module. */
        // CDU data
        public PMDG_NGX_CDU_Screen cdu0 = new PMDG_NGX_CDU_Screen(0x5400);
        public PMDG_NGX_CDU_Screen cdu1 = new PMDG_NGX_CDU_Screen(0x5800);
        public PMDG_NGX_CDU_Screen cdu2 = new PMDG_NGX_CDU_Screen(0x5C00);

        // constants for PMDG mouse click parameters
        public const int ClkL = 536870912;
        public const int ClkR = -2147483648;
        public const int Inc = 16384;
        public const int Dec = 8192;
        public void CalculateSwitchPosition(PMDG_737_NGX_Control control, int pos, int sel)
        {
            // there are several PMDG controls that cannot be set by direct parameter entry.
            // this function calculates the number of increment or decrement commands that need to be set in order to set a switch to a specific position.
            // We pass in a PMDG control number, an offset to read the current switch position, and the position we want the switch set to.
            if (pos > sel)
            {
                for (int i = 0; i < pos - sel; i++)
                {
                    FSUIPCConnection.SendControlToFS(control, Dec);
                }

            }
            if (pos < sel)
            {
                for (int i = 0; i < sel - pos; i++)
                {
                    FSUIPCConnection.SendControlToFS(control, Inc);

                }

            }

        }
        // overhead electrical
        // battery switch
        public void ElecBatteryOn()
        {
            // battery switch
            if (FSUIPCConnection.ReadLVar("switch_01_73X") != 100)
            {
                // battery switch guard
                if (FSUIPCConnection.ReadLVar("switch_02_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BATTERY_GUARD, ClkR);
                    Thread.Sleep(50);
                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BATTERY_SWITCH, ClkL);
                Thread.Sleep(250);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BATTERY_GUARD, ClkR);
            }
        }

        public void ElecBatteryOff()
        {
            // battery switch
            if (FSUIPCConnection.ReadLVar("switch_01_73X") != 0)
            {
                // battery switch guard
                if (FSUIPCConnection.ReadLVar("switch_02_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BATTERY_GUARD, ClkR);
                    Thread.Sleep(50);
                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BATTERY_SWITCH, ClkR);
            }
        }

        public void ElecBatteryToggle()
        {
            if (FSUIPCConnection.ReadLVar("switch_01_73X") != 100)
            {
                ElecBatteryOn();
            }
            else
            {
                ElecBatteryOff();
            }
        }

        // DC Meter Source
        public void ElecDCSource(int s)
        {
            if (s >= 0 && s <= 7)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_DC_METER, s);
                
            }

        }
        // AC Meter Source
        public void ElecACSource(int s)
        {
            if (s >= 0 && s <= 6)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_AC_METER, s);
            }

        }

        // Standby Power
        public void ElecStandbyBattery()
        {
            if (FSUIPCConnection.ReadLVar("switch_10_73X") != 0)
            {
                if (FSUIPCConnection.ReadLVar("switch_11_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_GUARD, ClkR);

                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkL);
                Thread.Sleep(250);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkL);

            }
        }

        public void ElecStandbyOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_10_73X") == 0)
            {
                if (FSUIPCConnection.ReadLVar("switch_11_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_GUARD, ClkR);
                    Thread.Sleep(50);
                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkR);

            }
            if (FSUIPCConnection.ReadLVar("switch_10_73X") == 100)
            {
                if (FSUIPCConnection.ReadLVar("switch_11_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_GUARD, ClkL);
                    Thread.Sleep(50);
                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkL);

            }
        }

        public void         ElecStandbyAuto()
        {
            if (FSUIPCConnection.ReadLVar("switch_10_73X") != 100)
            {
                if (FSUIPCConnection.ReadLVar("switch_11_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_GUARD, ClkR);

                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkR);
                Thread.Sleep(250);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_STBY_PWR_SWITCH, ClkR);

            }
        }
        // Bus Transfer
        public void ElecBusTransferOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_18_73X") != 0)
            {
                if (FSUIPCConnection.ReadLVar("switch_19_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BUS_TRANSFER_GUARD, ClkR);
                }
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BUS_TRANSFER_SWITCH, ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BUS_TRANSFER_SWITCH, ClkR);
            }
        }

        public void ElecBusTransferAuto()
        {
            if (FSUIPCConnection.ReadLVar("switch_18_73X") != 100)
            {
                if (FSUIPCConnection.ReadLVar("switch_19_73X") != 100)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_BUS_TRANSFER_GUARD, ClkR);
                }
            }
        }
        // cabin utility switch
        public void ElecCabUtilOn()
        {
            if (Aircraft.pmdg737.ELEC_CabUtilSw.Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_CAB_UTIL, Aircraft.ClkL);
            }
        }
        
        public void ElecCabUtilOff()
        {
            if (Aircraft.pmdg737.ELEC_CabUtilSw.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_CAB_UTIL, Aircraft.ClkR);
            }
        }
        // passenger seat power
        public void ElecSeatPowerOn()
        {
            if (Aircraft.pmdg737.ELEC_IFEPassSeatSw.Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_IFE, Aircraft.ClkL);
            }
        }
        
        public void ElecSeatPowerOff()
        {
            if (Aircraft.pmdg737.ELEC_IFEPassSeatSw.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_IFE, Aircraft.ClkR);
            }
        }
        
        // ground power switch
        public void ElecGroundPowerOn()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GRD_PWR_SWITCH, Aircraft.ClkL);
        }
        public void ElecGroundPowerOff()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GRD_PWR_SWITCH, Aircraft.ClkR);
        }

        // APU generators
        public void ElecAPUGen1On()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkL);
        }
        public void ElecAPUGen1Off()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_APU_GEN1_SWITCH, Aircraft.ClkR);
        }
        public void ElecAPUGen2On()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkL);
        }
        public void ElecAPUGen2Off()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_APU_GEN2_SWITCH, Aircraft.ClkR);
        }
        public void ElecGen1On()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GEN1_SWITCH, Aircraft.ClkL);
        }
        public void ElecGen1Off()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GEN1_SWITCH, Aircraft.ClkR);
        }
        public void ElecGen2On()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkL);
        }
        public void ElecGen2Off()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ELEC_GEN2_SWITCH, Aircraft.ClkR);
        }
// APU
public void ElecAPUStart()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_APU_START, Aircraft.ClkL);
            Thread.Sleep(250);
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_APU_START, Aircraft.ClkL);
        }
        public void ElecAPUShutdown ()
        {
            FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_LIGHTS_APU_START, Aircraft.ClkR);
        }

        public void mcpFlightDirectorLeftOn()
        {
            if (Aircraft.pmdg737.MCP_FDSw[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_FD_SWITCH_L, ClkL);
            }

        }
        public void mcpFlightDirectorLeftOff()
        {
            if (Aircraft.pmdg737.MCP_FDSw[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_FD_SWITCH_L, ClkR);
            }

        }
        public void mcpFlightDirectorRightOn()
        {
            if (Aircraft.pmdg737.MCP_FDSw[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_FD_SWITCH_R, ClkL);
            }

        }
        public void mcpFlightDirectorRightOff()
        {
            if (Aircraft.pmdg737.MCP_FDSw[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_FD_SWITCH_R, ClkR);
            }

        }
        public void mcpAutoThrottleArmOn()
        {
            if (Aircraft.pmdg737.MCP_ATArmSw.Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_AT_ARM_SWITCH, ClkL);

            }
        }
        public void mcpAutoThrottleArmOff()
        {
            if (Aircraft.pmdg737.MCP_ATArmSw.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_MCP_AT_ARM_SWITCH, ClkR);

            }
        }
        // fuel
        public void FuelFwdLeftOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpFwdSw[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_1_FORWARD, ClkL);
            }

        }
        public void FuelFwdLeftOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpFwdSw[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_1_FORWARD, ClkR);
            }

        }
        public void FuelFwdRightOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpFwdSw[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_2_FORWARD, ClkL);
            }

        }
        public void FuelFwdRightOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpFwdSw[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_2_FORWARD, ClkR);
            }

        }
        public void FuelAftLeftOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpAftSw[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_1_AFT, ClkL);
            }

        }
        public void FuelAftLeftOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpAftSw[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_1_AFT, ClkR);
            }

        }
        public void FuelAftRightOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpAftSw[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_2_AFT, ClkL);
            }

        }
        public void FuelAftRightOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpAftSw[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_2_AFT, ClkR);
            }

        }
        public void FuelCtrLeftOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpCtrSw[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_L_CENTER, ClkL);
            }

        }
        public void FuelCtrLeftOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpCtrSw[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_L_CENTER, ClkR);
            }

        }
        public void FuelCtrRightOn()
        {
            if (Aircraft.pmdg737.FUEL_PumpCtrSw[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_R_CENTER, ClkL);
            }

        }
        public void FuelCtrRightOff()
        {
            if (Aircraft.pmdg737.FUEL_PumpCtrSw[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_FUEL_PUMP_R_CENTER, ClkR);
            }

        }

        // hydraulic pumps
        public void HydElec1On()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_elec[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ELEC1, ClkL);
            }

        }
        public void HydElec1Off()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_elec[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ELEC1, ClkR);
            }

        }
        public void HydElec2On()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_elec[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ELEC2, ClkL);
            }

        }
        public void HydElec2Off()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_elec[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ELEC2, ClkR);
            }

        }
        public void HydEng2On()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_eng[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ENG2, ClkL);
            }

        }
        public void HydEng2Off()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_eng[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ENG2, ClkR);
            }

        }


        public void HydEng1On()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_eng[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ENG1, ClkL);
            }

        }
        public void HydEng1Off()
        {
            if (Aircraft.pmdg737.HYD_PumpSw_eng[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_HYD_ENG1, ClkR);
            }

        }

        // IRU Left
        
        public void IRULeftOff ()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Aircraft.pmdg737.IRS_ModeSelector[0].Value, 0);
        }
        public void IRULeftAlign ()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Aircraft.pmdg737.IRS_ModeSelector[0].Value, 1);
        }
        public void IRULeftNav()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Aircraft.pmdg737.IRS_ModeSelector[0].Value, 2);
        }

        public void IRULeftAtt()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Aircraft.pmdg737.IRS_ModeSelector[0].Value, 3);
        }

        
        
        public void IRURightOff ()
        {
            
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Aircraft.pmdg737.IRS_ModeSelector[1].Value, 0);
        }
        public void IRURightAlign()
        {
            // IRURightCalc(1);
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Aircraft.pmdg737.IRS_ModeSelector[1].Value, 1);
        }

        public void IRURightNav()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Aircraft.pmdg737.IRS_ModeSelector[1].Value, 2);
        }

        public void IRURightAtt()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Aircraft.pmdg737.IRS_ModeSelector[1].Value, 3);
        }

        // IRS display selector
        public void IRSDisplayTrackGS()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_ISDU_DSPL_SEL, Aircraft.pmdg737.IRS_DisplaySelector.Value, 1);
        }
        public void IRSDisplayPPOS()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_ISDU_DSPL_SEL, Aircraft.pmdg737.IRS_DisplaySelector.Value, 2);
        }
        public void IRSDisplayWind()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_ISDU_DSPL_SEL, Aircraft.pmdg737.IRS_DisplaySelector.Value, 3);
        }
        public void IRSDisplayHdgStat()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_ISDU_DSPL_SEL, Aircraft.pmdg737.IRS_DisplaySelector.Value, 4);
        }

        // engine controls
        public void Eng1StartGrd()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[0].Value, 0);
        }
        public void Eng1StartAuto()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[0].Value, 1);
        }
        public void Eng1StartCont()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[0].Value, 2);
        }
        public void Eng1StartFlt()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_L_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[0].Value, 3);
        }
        public void Eng2StartGrd()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[1].Value, 0);
        }
        public void Eng2StartAuto()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[1].Value, 1);
        }
        public void Eng2StartCont()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[1].Value, 2);
        }
        public void Eng2StartFlt()
        {
            CalculateSwitchPosition(PMDG_737_NGX_Control.EVT_OH_LIGHTS_R_ENGINE_START, Aircraft.pmdg737.ENG_StartSelector[1].Value, 3);
        }

        // Pedestal - Fuel Cut off
        public void Eng1FuelIdle ()
        {
            if (FSUIPCConnection.ReadLVar("switch_688_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG1_START_LEVER, ClkR);
            }
        }
        public void Eng1FuelCutOff ()
        {
            if (FSUIPCConnection.ReadLVar("switch_688_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG1_START_LEVER, ClkL);
            }
        }
        public void Eng2FuelIdle ()
        {
            if (FSUIPCConnection.ReadLVar("switch_689_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG2_START_LEVER, ClkR);
            }
        }
        public void Eng2FuelCutOff ()
        {
            if (FSUIPCConnection.ReadLVar("switch_689_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_CONTROL_STAND_ENG2_START_LEVER, ClkL);
            }
        }

        // Overhead window heat
        // left side
        public void WindowHeatLeftSideOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_135_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_1, ClkL);
            }

        }

        public void WindowHeatLeftSideOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_135_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_1, ClkR);
            }

        }
        // left forward
        public void WindowHeatLeftForwardOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_136_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_2, ClkL);
            }

        }

        public void WindowHeatLeftForwardOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_136_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_2, ClkR);
            }

        }

        // right forward
        public void WindowHeatRightForwardOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_138_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_3, ClkL);
            }

        }

        public void WindowHeatRightForwardOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_138_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_3, ClkR);
            }

        }

        // right side
        public void WindowHeatRightSideOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_139_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_4, ClkL);
            }

        }

        public void WindowHeatRightSideOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_139_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WINDOW_HEAT_4, ClkR);
            }

        }

        // overhead probe heat
        // left
        public void ProbeHeatLeftOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_140_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_PROBE_HEAT_1, ClkL);
            }

        }

        public void ProbeHeatLeftOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_140_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_PROBE_HEAT_1, ClkR);
            }

        }

        // right
        public void ProbeHeatRightOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_141_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_PROBE_HEAT_2, ClkL);
            }

        }

        public void ProbeHeatRightOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_141_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_PROBE_HEAT_2, ClkR);
            }

        }


        // wing anti-ice
        public void WingAntiIceOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_156_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WING_ANTIICE, ClkL);
            }

        }

        public void WingAntiIceOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_156_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_WING_ANTIICE, ClkR);
            }

        }

        // engine 1 anti-ice
        public void Engine1AntiIceOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_157_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_ENGINE_ANTIICE_1, ClkL);
            }

        }

        public void Engine1AntiIceOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_157_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_ENGINE_ANTIICE_1, ClkR);
            }

        }

        // engine 2 anti-ice
        public void Engine2AntiIceOn()
        {
            if (FSUIPCConnection.ReadLVar("switch_158_73X") != 100)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_ENGINE_ANTIICE_2, ClkL);
            }

        }

        public void Engine2AntiIceOff()
        {
            if (FSUIPCConnection.ReadLVar("switch_158_73X") != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_ICE_ENGINE_ANTIICE_2, ClkR);
            }

        }


        // air systems panel
// trim air
public void TrimAirOn()
        {
            if (Aircraft.pmdg737.AIR_TrimAirSwitch.Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_AIRCOND_TRIM_AIR_SWITCH_800, Aircraft.ClkL);
            }

        }

        public void TrimAirOff()
        {
            if (Aircraft.pmdg737.AIR_TrimAirSwitch.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_AIRCOND_TRIM_AIR_SWITCH_800, Aircraft.ClkR);
            }

        }

        // left recirculation fan
        public void RecircLeftOn()
        {
            if (Aircraft.pmdg737.AIR_RecircFanSwitch[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_RECIRC_FAN_L_SWITCH, Aircraft.ClkL);
            }

        }
        public void RecircLeftOff()
        {
            if (Aircraft.pmdg737.AIR_RecircFanSwitch[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_RECIRC_FAN_L_SWITCH, Aircraft.ClkR);
            }

        }
        // right recirculation fan
        public void RecircRightOn()
        {
            if (Aircraft.pmdg737.AIR_RecircFanSwitch[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_RECIRC_FAN_R_SWITCH, Aircraft.ClkL);
            }

        }
        public void RecircRightOff()
        {
            if (Aircraft.pmdg737.AIR_RecircFanSwitch[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_RECIRC_FAN_R_SWITCH, Aircraft.ClkR);
            }

        }

        // left aircon pack
        public void PackLeftHigh()
        {
if (Aircraft.pmdg737.AIR_PackSwitch[0].Value != 2)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkL);

            }
        }

        public void PackLeftAuto()
        {
            if (Aircraft.pmdg737.AIR_PackSwitch[0].Value > 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkR);
            }
            if (Aircraft.pmdg737.AIR_PackSwitch[0].Value < 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkL);
            }

        }

        public void PackLeftOff()
        {
            if (Aircraft.pmdg737.AIR_PackSwitch[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_L_SWITCH, ClkR);

            }

        }
        // right aircon pack
        public void PackRightHigh()
        {
if (Aircraft.pmdg737.AIR_PackSwitch[1].Value != 2)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkL);

            }
        }

        public void PackRightAuto()
        {
            if (Aircraft.pmdg737.AIR_PackSwitch[1].Value > 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkR);
            }
            if (Aircraft.pmdg737.AIR_PackSwitch[1].Value < 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkL);
            }

        }

        public void PackRightOff()
        {
            if (Aircraft.pmdg737.AIR_PackSwitch[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkR);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_PACK_R_SWITCH, ClkR);

            }

        }
        // isolation valve
        public void IsolValveOpen()
        {
if (Aircraft.pmdg737.AIR_IsolationValveSwitch.Value != 2)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkL);

            }
        }

        public void IsolValveAuto()
        {
            if (Aircraft.pmdg737.AIR_IsolationValveSwitch.Value > 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkR);
            }
            if (Aircraft.pmdg737.AIR_IsolationValveSwitch.Value < 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkL);
            }

        }

        public void IsolValveOff()
        {
            if (Aircraft.pmdg737.AIR_IsolationValveSwitch.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkL);
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ISOLATION_VALVE_SWITCH, ClkL);
                

            }

        }

        // air bleeds
        public void APUBleedOn()
        {
            if (Aircraft.pmdg737.AIR_APUBleedAirSwitch.Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_APU_SWITCH, ClkL);
            }

        }

        public void APUBleedOff()
        {
            if (Aircraft.pmdg737.AIR_APUBleedAirSwitch.Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_APU_SWITCH, ClkR);
            }
        }

        public void Engine1BleedOn()
        {
            if (Aircraft.pmdg737.AIR_BleedAirSwitch[0].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ENG_1_SWITCH, ClkL);
            }

        }
        public void Engine1BleedOff()
        {
            if (Aircraft.pmdg737.AIR_BleedAirSwitch[0].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ENG_1_SWITCH, ClkR);
            }

        }
        public void Engine2BleedOn()
        {
            if (Aircraft.pmdg737.AIR_BleedAirSwitch[1].Value != 1)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ENG_2_SWITCH, ClkL);
            }

        }
        public void Engine2BleedOff()
        {
            if (Aircraft.pmdg737.AIR_BleedAirSwitch[1].Value != 0)
            {
                FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_OH_BLEED_ENG_2_SWITCH, ClkR);
            }

        }
        // CDU screen refresh method
        /// <summary>
        ///  Populate data from PMDG CDU.
        /// </summary>
        /// <param name="CDUNumber">Number of the CDU to refresh. </param>
        /// <returns>String containing the CDU screen data</returns>
        public string RefreshCDU(int CDUNumber)
        {
            PMDG_NGX_CDU_Screen cdu = null;
            switch (CDUNumber)
            {
                case 0:
                cdu = cdu0;
                    break;
                case 1:
                    cdu = cdu1;
                    break;
                case 2:
                    cdu = cdu2;
                    break;

            }

            string CDUScreen = null;
            
            cdu.RefreshData();
            int rowCounter = 1;
            int lskCounter = 1;
            foreach (PMDG_NGX_CDU_Row row in cdu.Rows)
            {
                string RowOutput = null;
                if (new int[] { 3, 5, 7, 9, 11, 13 }.Contains(rowCounter))
                {
                    bool RowModified = false;
                    // CDU row clean up
                    for (int i = 0; i <= 23; i++)
                    {
                        // replace entry field character with underscores
                        if (Convert.ToInt32(row.Cells[i].Symbol) == 234)
                        {
                            row.Cells[i].Symbol = '_';
                        }
                        // replace left arrow with less than sign
                        if (Convert.ToInt32(row.Cells[i].Symbol) == 161)
                        {
                            row.Cells[i].Symbol = '<';
                        }
                        // replace right arrow with greater sign
                        if (Convert.ToInt32(row.Cells[i].Symbol) == 162)
                        {
                            row.Cells[i].Symbol = '>';
                        }

                    }
                    // if row contains <> then this is an option selection
                    if (row.ToString().Contains("<>"))
                    {
                        bool SelectedChoice = false;
                        RowModified = true;
                        for (int i = 0; i <= 23; i++)
                        {
                            // if we find a cell in red, green, or Amber, this is the start of a selected choice, put an X before the character and jump to the next character in the row
                            if ((row.Cells[i].Color == PMDG_NGX_CDU_COLOR.GREEN || row.Cells[i].Color == PMDG_NGX_CDU_COLOR.RED || row.Cells[i].Color == PMDG_NGX_CDU_COLOR.AMBER) && SelectedChoice == false)
                            {
                                RowOutput += $"x {row.Cells[i]}";
                                SelectedChoice = true;
                                continue;

                            }

                            // if the current character is red, green, or Amber, and the selected choice flag is true, just print the character and continue.
                            if ((row.Cells[i].Color == PMDG_NGX_CDU_COLOR.GREEN || row.Cells[i].Color == PMDG_NGX_CDU_COLOR.RED || row.Cells[i].Color == PMDG_NGX_CDU_COLOR.AMBER) && SelectedChoice)
                            {
                                RowOutput += row.Cells[i].Symbol;
                            }
                            // if the color is white, change the selected choice flag to false, print the character and continue
                            if (row.Cells[i].Color == PMDG_NGX_CDU_COLOR.WHITE)
                            {
                                RowOutput += row.Cells[i].Symbol;
                                SelectedChoice = false;
                            }
                        }

                    }

                    if (RowModified)
                    {
                        string RowOutputFinal = RowOutput.Replace("<>", " / ");
                        CDUScreen += $"{lskCounter}: {RowOutputFinal}\r\n";

                    }
                    else
                    {
                        // write the raw row to the output window, no modifications
                        CDUScreen += $"{lskCounter}: {row.ToString()}\r\n";

                    }
                    lskCounter++;
                }
                else
                {
                    CDUScreen += $"{row.ToString()}\r\n";
                }
                rowCounter++;
            }
            return CDUScreen;
            
        }

    }
}
