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
        // constants for PMDG mouse click parameters
        public const int ClkL = 536870912;
        public const int ClkR = -2147483648;
        public const int Inc = 16384;
        public const int Dec = 8192;

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

        public void ElecStandbyAuto()
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
        public void IRULeftCalc (int sel)
        {
            int pos = Aircraft.pmdg737.IRS_ModeSelector[0].Value;
            if (pos > sel)
            {
                for (int i = 0; i < pos - sel; i++)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Dec);
                }

            }
            if (pos < sel)
            {
                for (int i = 0; i < sel - pos; i++)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_IRU_MSU_LEFT, Inc);

                }

            }

        }
        public void IRULeftOff ()
        {
            IRULeftCalc(0);
        }
        public void IRULeftAlign ()
        {
            IRULeftCalc(1);
        }
        public void IRULeftNav()
        {
            IRULeftCalc(2);
        }

        public void IRULeftAtt()
        {
            IRULeftCalc(3   );
        }
        // IRU Right
        public void IRURightCalc (int sel)
        {
            int pos = Aircraft.pmdg737.IRS_ModeSelector[1].Value;
            if (pos > sel)
            {
                for (int i = 0; i < pos - sel; i++)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Dec);
                }

            }
            if (pos < sel)
            {
                for (int i = 0; i < sel - pos; i++)
                {
                    FSUIPCConnection.SendControlToFS(PMDG_737_NGX_Control.EVT_IRU_MSU_RIGHT, Inc);

                }

            }

        }
        public void IRURightOff ()
        {
            IRURightCalc(0);
        }
        public void IRURightAlign ()
        {
            IRURightCalc(1);
        }
        public void IRURightNav()
        {
            IRURightCalc(2);
        }

        public void IRURightAtt()
        {
            IRURightCalc(3   );
        }

    }
}
