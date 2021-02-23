﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IDAL;
namespace DALMsSql
{
	public partial class accountDAL : BaseDAL<account>,IaccountDAL
    {
    }
	public partial class AccountContInfoDAL : BaseDAL<AccountContInfo>,IAccountContInfoDAL
    {
    }
	public partial class AdditionalOutDAL : BaseDAL<AdditionalOut>,IAdditionalOutDAL
    {
    }
	public partial class Basic_Return_AddressDAL : BaseDAL<Basic_Return_Address>,IBasic_Return_AddressDAL
    {
    }
	public partial class Bn_ZodiacDAL : BaseDAL<Bn_Zodiac>,IBn_ZodiacDAL
    {
    }
	public partial class BookingDetailEdiDAL : BaseDAL<BookingDetailEdi>,IBookingDetailEdiDAL
    {
    }
	public partial class bookingDtlDAL : BaseDAL<bookingDtl>,IbookingDtlDAL
    {
    }
	public partial class bookingForwardDAL : BaseDAL<bookingForward>,IbookingForwardDAL
    {
    }
	public partial class bookingHeadDAL : BaseDAL<bookingHead>,IbookingHeadDAL
    {
    }
	public partial class BookingHeadEdiDAL : BaseDAL<BookingHeadEdi>,IBookingHeadEdiDAL
    {
    }
	public partial class bookingUserDAL : BaseDAL<bookingUser>,IbookingUserDAL
    {
    }
	public partial class bookingVendorDAL : BaseDAL<bookingVendor>,IbookingVendorDAL
    {
    }
	public partial class carrier_bookingDAL : BaseDAL<carrier_booking>,Icarrier_bookingDAL
    {
    }
	public partial class CarrierInfoDAL : BaseDAL<CarrierInfo>,ICarrierInfoDAL
    {
    }
	public partial class categoryDAL : BaseDAL<category>,IcategoryDAL
    {
    }
	public partial class ChargeDEBITNOTEDAL : BaseDAL<ChargeDEBITNOTE>,IChargeDEBITNOTEDAL
    {
    }
	public partial class ChargeNameDAL : BaseDAL<ChargeName>,IChargeNameDAL
    {
    }
	public partial class ClientDAL : BaseDAL<Client>,IClientDAL
    {
    }
	public partial class clp_chargeListDAL : BaseDAL<clp_chargeList>,Iclp_chargeListDAL
    {
    }
	public partial class collectlistDAL : BaseDAL<collectlist>,IcollectlistDAL
    {
    }
	public partial class con_sizeDAL : BaseDAL<con_size>,Icon_sizeDAL
    {
    }
	public partial class consigneeDAL : BaseDAL<consignee>,IconsigneeDAL
    {
    }
	public partial class cont_addressDAL : BaseDAL<cont_address>,Icont_addressDAL
    {
    }
	public partial class Cont_SizeDAL : BaseDAL<Cont_Size>,ICont_SizeDAL
    {
    }
	public partial class ContTransFeeDAL : BaseDAL<ContTransFee>,IContTransFeeDAL
    {
    }
	public partial class Curr_RateDAL : BaseDAL<Curr_Rate>,ICurr_RateDAL
    {
    }
	public partial class cus_contDAL : BaseDAL<cus_cont>,Icus_contDAL
    {
    }
	public partial class cus_hchgDAL : BaseDAL<cus_hchg>,Icus_hchgDAL
    {
    }
	public partial class custinDAL : BaseDAL<custin>,IcustinDAL
    {
    }
	public partial class custinnoDAL : BaseDAL<custinno>,IcustinnoDAL
    {
    }
	public partial class customerDAL : BaseDAL<customer>,IcustomerDAL
    {
    }
	public partial class Customer_OrderDAL : BaseDAL<Customer_Order>,ICustomer_OrderDAL
    {
    }
	public partial class Customer_Order_PlanDAL : BaseDAL<Customer_Order_Plan>,ICustomer_Order_PlanDAL
    {
    }
	public partial class customer1DAL : BaseDAL<customer1>,Icustomer1DAL
    {
    }
	public partial class customsDAL : BaseDAL<customs>,IcustomsDAL
    {
    }
	public partial class customs_headDAL : BaseDAL<customs_head>,Icustoms_headDAL
    {
    }
	public partial class customs_itemDAL : BaseDAL<customs_item>,Icustoms_itemDAL
    {
    }
	public partial class customs_outDAL : BaseDAL<customs_out>,Icustoms_outDAL
    {
    }
	public partial class CustomsTypeDAL : BaseDAL<CustomsType>,ICustomsTypeDAL
    {
    }
	public partial class custoutnoDAL : BaseDAL<custoutno>,IcustoutnoDAL
    {
    }
	public partial class DailyCustomsDocuDAL : BaseDAL<DailyCustomsDocu>,IDailyCustomsDocuDAL
    {
    }
	public partial class DailyDataforCustomsDAL : BaseDAL<DailyDataforCustoms>,IDailyDataforCustomsDAL
    {
    }
	public partial class DailyTurnoverDAL : BaseDAL<DailyTurnover>,IDailyTurnoverDAL
    {
    }
	public partial class DebitNoteNoDAL : BaseDAL<DebitNoteNo>,IDebitNoteNoDAL
    {
    }
	public partial class decl_noDAL : BaseDAL<decl_no>,Idecl_noDAL
    {
    }
	public partial class destDAL : BaseDAL<dest>,IdestDAL
    {
    }
	public partial class destinationDAL : BaseDAL<destination>,IdestinationDAL
    {
    }
	public partial class DestInfo2DAL : BaseDAL<DestInfo2>,IDestInfo2DAL
    {
    }
	public partial class DestOfBRSIDAL : BaseDAL<DestOfBRSI>,IDestOfBRSIDAL
    {
    }
	public partial class dobitNoteLogDAL : BaseDAL<dobitNoteLog>,IdobitNoteLogDAL
    {
    }
	public partial class dtpropertiesDAL : BaseDAL<dtproperties>,IdtpropertiesDAL
    {
    }
	public partial class EDIExcptnRegDAL : BaseDAL<EDIExcptnReg>,IEDIExcptnRegDAL
    {
    }
	public partial class EmployeesDAL : BaseDAL<Employees>,IEmployeesDAL
    {
    }
	public partial class Exchange_RateDAL : BaseDAL<Exchange_Rate>,IExchange_RateDAL
    {
    }
	public partial class ExclusionCustomsDAL : BaseDAL<ExclusionCustoms>,IExclusionCustomsDAL
    {
    }
	public partial class FCR_DetailDAL : BaseDAL<FCR_Detail>,IFCR_DetailDAL
    {
    }
	public partial class FCR_Discharging_PortDAL : BaseDAL<FCR_Discharging_Port>,IFCR_Discharging_PortDAL
    {
    }
	public partial class FCR_FactoryDAL : BaseDAL<FCR_Factory>,IFCR_FactoryDAL
    {
    }
	public partial class FCR_HeadDAL : BaseDAL<FCR_Head>,IFCR_HeadDAL
    {
    }
	public partial class FCR_SupplierDAL : BaseDAL<FCR_Supplier>,IFCR_SupplierDAL
    {
    }
	public partial class FcrSMBaseChargeDAL : BaseDAL<FcrSMBaseCharge>,IFcrSMBaseChargeDAL
    {
    }
	public partial class FinalLoadingPlanDAL : BaseDAL<FinalLoadingPlan>,IFinalLoadingPlanDAL
    {
    }
	public partial class FinalLoadingPlan_PaymentDAL : BaseDAL<FinalLoadingPlan_Payment>,IFinalLoadingPlan_PaymentDAL
    {
    }
	public partial class FinalLoadPlanAmazonVendorDAL : BaseDAL<FinalLoadPlanAmazonVendor>,IFinalLoadPlanAmazonVendorDAL
    {
    }
	public partial class FinalLoadPlanHolidayDAL : BaseDAL<FinalLoadPlanHoliday>,IFinalLoadPlanHolidayDAL
    {
    }
	public partial class FinalLoadPlanJobRecordDAL : BaseDAL<FinalLoadPlanJobRecord>,IFinalLoadPlanJobRecordDAL
    {
    }
	public partial class FinalLoadPlanRPALogDAL : BaseDAL<FinalLoadPlanRPALog>,IFinalLoadPlanRPALogDAL
    {
    }
	public partial class FinalPo_Cancel_RecordDAL : BaseDAL<FinalPo_Cancel_Record>,IFinalPo_Cancel_RecordDAL
    {
    }
	public partial class FinalPoListDAL : BaseDAL<FinalPoList>,IFinalPoListDAL
    {
    }
	public partial class FinalVendorInputDAL : BaseDAL<FinalVendorInput>,IFinalVendorInputDAL
    {
    }
	public partial class FinalVendorInputLogDAL : BaseDAL<FinalVendorInputLog>,IFinalVendorInputLogDAL
    {
    }
	public partial class FinalVendorInputTruckingDAL : BaseDAL<FinalVendorInputTrucking>,IFinalVendorInputTruckingDAL
    {
    }
	public partial class financeChargeDAL : BaseDAL<financeCharge>,IfinanceChargeDAL
    {
    }
	public partial class forwarder_codeDAL : BaseDAL<forwarder_code>,Iforwarder_codeDAL
    {
    }
	public partial class in_headDAL : BaseDAL<in_head>,Iin_headDAL
    {
    }
	public partial class in_itemDAL : BaseDAL<in_item>,Iin_itemDAL
    {
    }
	public partial class In2SoDAL : BaseDAL<In2So>,IIn2SoDAL
    {
    }
	public partial class InDocContainerDAL : BaseDAL<InDocContainer>,IInDocContainerDAL
    {
    }
	public partial class InDocVehicleDAL : BaseDAL<InDocVehicle>,IInDocVehicleDAL
    {
    }
	public partial class InheadDAL : BaseDAL<Inhead>,IInheadDAL
    {
    }
	public partial class InListDAL : BaseDAL<InList>,IInListDAL
    {
    }
	public partial class invoiceDAL : BaseDAL<invoice>,IinvoiceDAL
    {
    }
	public partial class invoiceExchangeDAL : BaseDAL<invoiceExchange>,IinvoiceExchangeDAL
    {
    }
	public partial class latecomeDAL : BaseDAL<latecome>,IlatecomeDAL
    {
    }
	public partial class Load_FeeDAL : BaseDAL<Load_Fee>,ILoad_FeeDAL
    {
    }
	public partial class LoadingDAL : BaseDAL<Loading>,ILoadingDAL
    {
    }
	public partial class LoadPlanUpdateRecordDAL : BaseDAL<LoadPlanUpdateRecord>,ILoadPlanUpdateRecordDAL
    {
    }
	public partial class LPCont_InfoDAL : BaseDAL<LPCont_Info>,ILPCont_InfoDAL
    {
    }
	public partial class LPStatusDAL : BaseDAL<LPStatus>,ILPStatusDAL
    {
    }
	public partial class MaxIdDAL : BaseDAL<MaxId>,IMaxIdDAL
    {
    }
	public partial class newpackingDAL : BaseDAL<newpacking>,InewpackingDAL
    {
    }
	public partial class newpacklistDAL : BaseDAL<newpacklist>,InewpacklistDAL
    {
    }
	public partial class out_headDAL : BaseDAL<out_head>,Iout_headDAL
    {
    }
	public partial class out_head_cyDAL : BaseDAL<out_head_cy>,Iout_head_cyDAL
    {
    }
	public partial class out_itemDAL : BaseDAL<out_item>,Iout_itemDAL
    {
    }
	public partial class out_item_cyDAL : BaseDAL<out_item_cy>,Iout_item_cyDAL
    {
    }
	public partial class OutDocContainerDAL : BaseDAL<OutDocContainer>,IOutDocContainerDAL
    {
    }
	public partial class OutDocVehicleDAL : BaseDAL<OutDocVehicle>,IOutDocVehicleDAL
    {
    }
	public partial class OutheadDAL : BaseDAL<Outhead>,IOutheadDAL
    {
    }
	public partial class OutListDAL : BaseDAL<OutList>,IOutListDAL
    {
    }
	public partial class OutListItemsDAL : BaseDAL<OutListItems>,IOutListItemsDAL
    {
    }
	public partial class pick_return_chargeDAL : BaseDAL<pick_return_charge>,Ipick_return_chargeDAL
    {
    }
	public partial class PortDAL : BaseDAL<Port>,IPortDAL
    {
    }
	public partial class ProdesOfVIFADAL : BaseDAL<ProdesOfVIFA>,IProdesOfVIFADAL
    {
    }
	public partial class rec_amountDAL : BaseDAL<rec_amount>,Irec_amountDAL
    {
    }
	public partial class recdtlDAL : BaseDAL<recdtl>,IrecdtlDAL
    {
    }
	public partial class recheadDAL : BaseDAL<rechead>,IrecheadDAL
    {
    }
	public partial class RecRegistrationHeadDAL : BaseDAL<RecRegistrationHead>,IRecRegistrationHeadDAL
    {
    }
	public partial class RecRegistrationItemsDAL : BaseDAL<RecRegistrationItems>,IRecRegistrationItemsDAL
    {
    }
	public partial class RecRegVehicleDAL : BaseDAL<RecRegVehicle>,IRecRegVehicleDAL
    {
    }
	public partial class repertoryDAL : BaseDAL<repertory>,IrepertoryDAL
    {
    }
	public partial class serviceDAL : BaseDAL<service>,IserviceDAL
    {
    }
	public partial class shipcorpDAL : BaseDAL<shipcorp>,IshipcorpDAL
    {
    }
	public partial class ShipperNameListDAL : BaseDAL<ShipperNameList>,IShipperNameListDAL
    {
    }
	public partial class ShipToDAL : BaseDAL<ShipTo>,IShipToDAL
    {
    }
	public partial class SMFOBDebitNoteRateAutomaticgrowthDAL : BaseDAL<SMFOBDebitNoteRateAutomaticgrowth>,ISMFOBDebitNoteRateAutomaticgrowthDAL
    {
    }
	public partial class spe_opertypeDAL : BaseDAL<spe_opertype>,Ispe_opertypeDAL
    {
    }
	public partial class specialDAL : BaseDAL<special>,IspecialDAL
    {
    }
	public partial class special_itemDAL : BaseDAL<special_item>,Ispecial_itemDAL
    {
    }
	public partial class SpsOperateDAL : BaseDAL<SpsOperate>,ISpsOperateDAL
    {
    }
	public partial class Sys_DepartmentDAL : BaseDAL<Sys_Department>,ISys_DepartmentDAL
    {
    }
	public partial class Sys_EasyUIDAL : BaseDAL<Sys_EasyUI>,ISys_EasyUIDAL
    {
    }
	public partial class Sys_LogDAL : BaseDAL<Sys_Log>,ISys_LogDAL
    {
    }
	public partial class Sys_PermissionDAL : BaseDAL<Sys_Permission>,ISys_PermissionDAL
    {
    }
	public partial class Sys_RoleDAL : BaseDAL<Sys_Role>,ISys_RoleDAL
    {
    }
	public partial class Sys_RolePermissionDAL : BaseDAL<Sys_RolePermission>,ISys_RolePermissionDAL
    {
    }
	public partial class Sys_UserInfoDAL : BaseDAL<Sys_UserInfo>,ISys_UserInfoDAL
    {
    }
	public partial class Sys_UserRoleDAL : BaseDAL<Sys_UserRole>,ISys_UserRoleDAL
    {
    }
	public partial class Sys_UserSettingDAL : BaseDAL<Sys_UserSetting>,ISys_UserSettingDAL
    {
    }
	public partial class Sys_UserVipPermissionDAL : BaseDAL<Sys_UserVipPermission>,ISys_UserVipPermissionDAL
    {
    }
	public partial class sysdiagramsDAL : BaseDAL<sysdiagrams>,IsysdiagramsDAL
    {
    }
	public partial class Truck_AccountDAL : BaseDAL<Truck_Account>,ITruck_AccountDAL
    {
    }
	public partial class Truck_Account2DAL : BaseDAL<Truck_Account2>,ITruck_Account2DAL
    {
    }
	public partial class Truck_Booking_ChargeDAL : BaseDAL<Truck_Booking_Charge>,ITruck_Booking_ChargeDAL
    {
    }
	public partial class Truck_Booking_ClientChargeDAL : BaseDAL<Truck_Booking_ClientCharge>,ITruck_Booking_ClientChargeDAL
    {
    }
	public partial class Truck_Booking_DetailDAL : BaseDAL<Truck_Booking_Detail>,ITruck_Booking_DetailDAL
    {
    }
	public partial class Truck_Booking_FileDAL : BaseDAL<Truck_Booking_File>,ITruck_Booking_FileDAL
    {
    }
	public partial class Truck_Booking_HeadDAL : BaseDAL<Truck_Booking_Head>,ITruck_Booking_HeadDAL
    {
    }
	public partial class Truck_Booking_RegDAL : BaseDAL<Truck_Booking_Reg>,ITruck_Booking_RegDAL
    {
    }
	public partial class Truck_CBM_WeightDAL : BaseDAL<Truck_CBM_Weight>,ITruck_CBM_WeightDAL
    {
    }
	public partial class Truck_ChargeNameDAL : BaseDAL<Truck_ChargeName>,ITruck_ChargeNameDAL
    {
    }
	public partial class Truck_ClientDAL : BaseDAL<Truck_Client>,ITruck_ClientDAL
    {
    }
	public partial class Truck_CompanyDAL : BaseDAL<Truck_Company>,ITruck_CompanyDAL
    {
    }
	public partial class Truck_Delivery_AddressDAL : BaseDAL<Truck_Delivery_Address>,ITruck_Delivery_AddressDAL
    {
    }
	public partial class Truck_DestDAL : BaseDAL<Truck_Dest>,ITruck_DestDAL
    {
    }
	public partial class Truck_Exchange_RateDAL : BaseDAL<Truck_Exchange_Rate>,ITruck_Exchange_RateDAL
    {
    }
	public partial class Truck_InvoiceDAL : BaseDAL<Truck_Invoice>,ITruck_InvoiceDAL
    {
    }
	public partial class Truck_Invoice_CodeDAL : BaseDAL<Truck_Invoice_Code>,ITruck_Invoice_CodeDAL
    {
    }
	public partial class Truck_Invoice_InfoDAL : BaseDAL<Truck_Invoice_Info>,ITruck_Invoice_InfoDAL
    {
    }
	public partial class Truck_Invoice_Info_AddDAL : BaseDAL<Truck_Invoice_Info_Add>,ITruck_Invoice_Info_AddDAL
    {
    }
	public partial class Truck_Loading_AddressDAL : BaseDAL<Truck_Loading_Address>,ITruck_Loading_AddressDAL
    {
    }
	public partial class Truck_PackingListDAL : BaseDAL<Truck_PackingList>,ITruck_PackingListDAL
    {
    }
	public partial class Truck_PODAL : BaseDAL<Truck_PO>,ITruck_PODAL
    {
    }
	public partial class Truck_Storage_YardDAL : BaseDAL<Truck_Storage_Yard>,ITruck_Storage_YardDAL
    {
    }
	public partial class Truck_VendorDAL : BaseDAL<Truck_Vendor>,ITruck_VendorDAL
    {
    }
	public partial class Truck_Vendor_ClientDAL : BaseDAL<Truck_Vendor_Client>,ITruck_Vendor_ClientDAL
    {
    }
	public partial class Truck_WarehouseDAL : BaseDAL<Truck_Warehouse>,ITruck_WarehouseDAL
    {
    }
	public partial class TruckUnLoadTimeDAL : BaseDAL<TruckUnLoadTime>,ITruckUnLoadTimeDAL
    {
    }
	public partial class turnoverDAL : BaseDAL<turnover>,IturnoverDAL
    {
    }
	public partial class unitDAL : BaseDAL<unit>,IunitDAL
    {
    }
	public partial class UnloadingDAL : BaseDAL<Unloading>,IUnloadingDAL
    {
    }
	public partial class User_PasswordDAL : BaseDAL<User_Password>,IUser_PasswordDAL
    {
    }
	public partial class userlogDAL : BaseDAL<userlog>,IuserlogDAL
    {
    }
	public partial class VehicleDAL : BaseDAL<Vehicle>,IVehicleDAL
    {
    }
	public partial class vendorDAL : BaseDAL<vendor>,IvendorDAL
    {
    }
	public partial class VendorInfoDAL : BaseDAL<VendorInfo>,IVendorInfoDAL
    {
    }
	public partial class vesselDAL : BaseDAL<vessel>,IvesselDAL
    {
    }
	public partial class whsDAL : BaseDAL<whs>,IwhsDAL
    {
    }
	public partial class ypmfuserDAL : BaseDAL<ypmfuser>,IypmfuserDAL
    {
    }
}