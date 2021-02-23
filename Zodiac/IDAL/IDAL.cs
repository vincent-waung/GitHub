﻿
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
namespace IDAL
{
	public partial interface IaccountDAL : IBaseDAL<account>
    {
    }

	public partial interface IAccountContInfoDAL : IBaseDAL<AccountContInfo>
    {
    }

	public partial interface IAdditionalOutDAL : IBaseDAL<AdditionalOut>
    {
    }

	public partial interface IBasic_Return_AddressDAL : IBaseDAL<Basic_Return_Address>
    {
    }

	public partial interface IBn_ZodiacDAL : IBaseDAL<Bn_Zodiac>
    {
    }

	public partial interface IBookingDetailEdiDAL : IBaseDAL<BookingDetailEdi>
    {
    }

	public partial interface IbookingDtlDAL : IBaseDAL<bookingDtl>
    {
    }

	public partial interface IbookingForwardDAL : IBaseDAL<bookingForward>
    {
    }

	public partial interface IbookingHeadDAL : IBaseDAL<bookingHead>
    {
    }

	public partial interface IBookingHeadEdiDAL : IBaseDAL<BookingHeadEdi>
    {
    }

	public partial interface IbookingUserDAL : IBaseDAL<bookingUser>
    {
    }

	public partial interface IbookingVendorDAL : IBaseDAL<bookingVendor>
    {
    }

	public partial interface Icarrier_bookingDAL : IBaseDAL<carrier_booking>
    {
    }

	public partial interface ICarrierInfoDAL : IBaseDAL<CarrierInfo>
    {
    }

	public partial interface IcategoryDAL : IBaseDAL<category>
    {
    }

	public partial interface IChargeDEBITNOTEDAL : IBaseDAL<ChargeDEBITNOTE>
    {
    }

	public partial interface IChargeNameDAL : IBaseDAL<ChargeName>
    {
    }

	public partial interface IClientDAL : IBaseDAL<Client>
    {
    }

	public partial interface Iclp_chargeListDAL : IBaseDAL<clp_chargeList>
    {
    }

	public partial interface IcollectlistDAL : IBaseDAL<collectlist>
    {
    }

	public partial interface Icon_sizeDAL : IBaseDAL<con_size>
    {
    }

	public partial interface IconsigneeDAL : IBaseDAL<consignee>
    {
    }

	public partial interface Icont_addressDAL : IBaseDAL<cont_address>
    {
    }

	public partial interface ICont_SizeDAL : IBaseDAL<Cont_Size>
    {
    }

	public partial interface IContTransFeeDAL : IBaseDAL<ContTransFee>
    {
    }

	public partial interface ICurr_RateDAL : IBaseDAL<Curr_Rate>
    {
    }

	public partial interface Icus_contDAL : IBaseDAL<cus_cont>
    {
    }

	public partial interface Icus_hchgDAL : IBaseDAL<cus_hchg>
    {
    }

	public partial interface IcustinDAL : IBaseDAL<custin>
    {
    }

	public partial interface IcustinnoDAL : IBaseDAL<custinno>
    {
    }

	public partial interface IcustomerDAL : IBaseDAL<customer>
    {
    }

	public partial interface ICustomer_OrderDAL : IBaseDAL<Customer_Order>
    {
    }

	public partial interface ICustomer_Order_PlanDAL : IBaseDAL<Customer_Order_Plan>
    {
    }

	public partial interface Icustomer1DAL : IBaseDAL<customer1>
    {
    }

	public partial interface IcustomsDAL : IBaseDAL<customs>
    {
    }

	public partial interface Icustoms_headDAL : IBaseDAL<customs_head>
    {
    }

	public partial interface Icustoms_itemDAL : IBaseDAL<customs_item>
    {
    }

	public partial interface Icustoms_outDAL : IBaseDAL<customs_out>
    {
    }

	public partial interface ICustomsTypeDAL : IBaseDAL<CustomsType>
    {
    }

	public partial interface IcustoutnoDAL : IBaseDAL<custoutno>
    {
    }

	public partial interface IDailyCustomsDocuDAL : IBaseDAL<DailyCustomsDocu>
    {
    }

	public partial interface IDailyDataforCustomsDAL : IBaseDAL<DailyDataforCustoms>
    {
    }

	public partial interface IDailyTurnoverDAL : IBaseDAL<DailyTurnover>
    {
    }

	public partial interface IDebitNoteNoDAL : IBaseDAL<DebitNoteNo>
    {
    }

	public partial interface Idecl_noDAL : IBaseDAL<decl_no>
    {
    }

	public partial interface IdestDAL : IBaseDAL<dest>
    {
    }

	public partial interface IdestinationDAL : IBaseDAL<destination>
    {
    }

	public partial interface IDestInfo2DAL : IBaseDAL<DestInfo2>
    {
    }

	public partial interface IDestOfBRSIDAL : IBaseDAL<DestOfBRSI>
    {
    }

	public partial interface IdobitNoteLogDAL : IBaseDAL<dobitNoteLog>
    {
    }

	public partial interface IdtpropertiesDAL : IBaseDAL<dtproperties>
    {
    }

	public partial interface IEDIExcptnRegDAL : IBaseDAL<EDIExcptnReg>
    {
    }

	public partial interface IEmployeesDAL : IBaseDAL<Employees>
    {
    }

	public partial interface IExchange_RateDAL : IBaseDAL<Exchange_Rate>
    {
    }

	public partial interface IExclusionCustomsDAL : IBaseDAL<ExclusionCustoms>
    {
    }

	public partial interface IFCR_DetailDAL : IBaseDAL<FCR_Detail>
    {
    }

	public partial interface IFCR_Discharging_PortDAL : IBaseDAL<FCR_Discharging_Port>
    {
    }

	public partial interface IFCR_FactoryDAL : IBaseDAL<FCR_Factory>
    {
    }

	public partial interface IFCR_HeadDAL : IBaseDAL<FCR_Head>
    {
    }

	public partial interface IFCR_SupplierDAL : IBaseDAL<FCR_Supplier>
    {
    }

	public partial interface IFcrSMBaseChargeDAL : IBaseDAL<FcrSMBaseCharge>
    {
    }

	public partial interface IFinalLoadingPlanDAL : IBaseDAL<FinalLoadingPlan>
    {
    }

	public partial interface IFinalLoadingPlan_PaymentDAL : IBaseDAL<FinalLoadingPlan_Payment>
    {
    }

	public partial interface IFinalLoadPlanAmazonVendorDAL : IBaseDAL<FinalLoadPlanAmazonVendor>
    {
    }

	public partial interface IFinalLoadPlanHolidayDAL : IBaseDAL<FinalLoadPlanHoliday>
    {
    }

	public partial interface IFinalLoadPlanJobRecordDAL : IBaseDAL<FinalLoadPlanJobRecord>
    {
    }

	public partial interface IFinalLoadPlanRPALogDAL : IBaseDAL<FinalLoadPlanRPALog>
    {
    }

	public partial interface IFinalPo_Cancel_RecordDAL : IBaseDAL<FinalPo_Cancel_Record>
    {
    }

	public partial interface IFinalPoListDAL : IBaseDAL<FinalPoList>
    {
    }

	public partial interface IFinalVendorInputDAL : IBaseDAL<FinalVendorInput>
    {
    }

	public partial interface IFinalVendorInputLogDAL : IBaseDAL<FinalVendorInputLog>
    {
    }

	public partial interface IFinalVendorInputTruckingDAL : IBaseDAL<FinalVendorInputTrucking>
    {
    }

	public partial interface IfinanceChargeDAL : IBaseDAL<financeCharge>
    {
    }

	public partial interface Iforwarder_codeDAL : IBaseDAL<forwarder_code>
    {
    }

	public partial interface Iin_headDAL : IBaseDAL<in_head>
    {
    }

	public partial interface Iin_itemDAL : IBaseDAL<in_item>
    {
    }

	public partial interface IIn2SoDAL : IBaseDAL<In2So>
    {
    }

	public partial interface IInDocContainerDAL : IBaseDAL<InDocContainer>
    {
    }

	public partial interface IInDocVehicleDAL : IBaseDAL<InDocVehicle>
    {
    }

	public partial interface IInheadDAL : IBaseDAL<Inhead>
    {
    }

	public partial interface IInListDAL : IBaseDAL<InList>
    {
    }

	public partial interface IinvoiceDAL : IBaseDAL<invoice>
    {
    }

	public partial interface IinvoiceExchangeDAL : IBaseDAL<invoiceExchange>
    {
    }

	public partial interface IlatecomeDAL : IBaseDAL<latecome>
    {
    }

	public partial interface ILoad_FeeDAL : IBaseDAL<Load_Fee>
    {
    }

	public partial interface ILoadingDAL : IBaseDAL<Loading>
    {
    }

	public partial interface ILoadPlanUpdateRecordDAL : IBaseDAL<LoadPlanUpdateRecord>
    {
    }

	public partial interface ILPCont_InfoDAL : IBaseDAL<LPCont_Info>
    {
    }

	public partial interface ILPStatusDAL : IBaseDAL<LPStatus>
    {
    }

	public partial interface IMaxIdDAL : IBaseDAL<MaxId>
    {
    }

	public partial interface InewpackingDAL : IBaseDAL<newpacking>
    {
    }

	public partial interface InewpacklistDAL : IBaseDAL<newpacklist>
    {
    }

	public partial interface Iout_headDAL : IBaseDAL<out_head>
    {
    }

	public partial interface Iout_head_cyDAL : IBaseDAL<out_head_cy>
    {
    }

	public partial interface Iout_itemDAL : IBaseDAL<out_item>
    {
    }

	public partial interface Iout_item_cyDAL : IBaseDAL<out_item_cy>
    {
    }

	public partial interface IOutDocContainerDAL : IBaseDAL<OutDocContainer>
    {
    }

	public partial interface IOutDocVehicleDAL : IBaseDAL<OutDocVehicle>
    {
    }

	public partial interface IOutheadDAL : IBaseDAL<Outhead>
    {
    }

	public partial interface IOutListDAL : IBaseDAL<OutList>
    {
    }

	public partial interface IOutListItemsDAL : IBaseDAL<OutListItems>
    {
    }

	public partial interface Ipick_return_chargeDAL : IBaseDAL<pick_return_charge>
    {
    }

	public partial interface IPortDAL : IBaseDAL<Port>
    {
    }

	public partial interface IProdesOfVIFADAL : IBaseDAL<ProdesOfVIFA>
    {
    }

	public partial interface Irec_amountDAL : IBaseDAL<rec_amount>
    {
    }

	public partial interface IrecdtlDAL : IBaseDAL<recdtl>
    {
    }

	public partial interface IrecheadDAL : IBaseDAL<rechead>
    {
    }

	public partial interface IRecRegistrationHeadDAL : IBaseDAL<RecRegistrationHead>
    {
    }

	public partial interface IRecRegistrationItemsDAL : IBaseDAL<RecRegistrationItems>
    {
    }

	public partial interface IRecRegVehicleDAL : IBaseDAL<RecRegVehicle>
    {
    }

	public partial interface IrepertoryDAL : IBaseDAL<repertory>
    {
    }

	public partial interface IserviceDAL : IBaseDAL<service>
    {
    }

	public partial interface IshipcorpDAL : IBaseDAL<shipcorp>
    {
    }

	public partial interface IShipperNameListDAL : IBaseDAL<ShipperNameList>
    {
    }

	public partial interface IShipToDAL : IBaseDAL<ShipTo>
    {
    }

	public partial interface ISMFOBDebitNoteRateAutomaticgrowthDAL : IBaseDAL<SMFOBDebitNoteRateAutomaticgrowth>
    {
    }

	public partial interface Ispe_opertypeDAL : IBaseDAL<spe_opertype>
    {
    }

	public partial interface IspecialDAL : IBaseDAL<special>
    {
    }

	public partial interface Ispecial_itemDAL : IBaseDAL<special_item>
    {
    }

	public partial interface ISpsOperateDAL : IBaseDAL<SpsOperate>
    {
    }

	public partial interface ISys_DepartmentDAL : IBaseDAL<Sys_Department>
    {
    }

	public partial interface ISys_EasyUIDAL : IBaseDAL<Sys_EasyUI>
    {
    }

	public partial interface ISys_LogDAL : IBaseDAL<Sys_Log>
    {
    }

	public partial interface ISys_PermissionDAL : IBaseDAL<Sys_Permission>
    {
    }

	public partial interface ISys_RoleDAL : IBaseDAL<Sys_Role>
    {
    }

	public partial interface ISys_RolePermissionDAL : IBaseDAL<Sys_RolePermission>
    {
    }

	public partial interface ISys_UserInfoDAL : IBaseDAL<Sys_UserInfo>
    {
    }

	public partial interface ISys_UserRoleDAL : IBaseDAL<Sys_UserRole>
    {
    }

	public partial interface ISys_UserSettingDAL : IBaseDAL<Sys_UserSetting>
    {
    }

	public partial interface ISys_UserVipPermissionDAL : IBaseDAL<Sys_UserVipPermission>
    {
    }

	public partial interface IsysdiagramsDAL : IBaseDAL<sysdiagrams>
    {
    }

	public partial interface ITruck_AccountDAL : IBaseDAL<Truck_Account>
    {
    }

	public partial interface ITruck_Account2DAL : IBaseDAL<Truck_Account2>
    {
    }

	public partial interface ITruck_Booking_ChargeDAL : IBaseDAL<Truck_Booking_Charge>
    {
    }

	public partial interface ITruck_Booking_ClientChargeDAL : IBaseDAL<Truck_Booking_ClientCharge>
    {
    }

	public partial interface ITruck_Booking_DetailDAL : IBaseDAL<Truck_Booking_Detail>
    {
    }

	public partial interface ITruck_Booking_FileDAL : IBaseDAL<Truck_Booking_File>
    {
    }

	public partial interface ITruck_Booking_HeadDAL : IBaseDAL<Truck_Booking_Head>
    {
    }

	public partial interface ITruck_Booking_RegDAL : IBaseDAL<Truck_Booking_Reg>
    {
    }

	public partial interface ITruck_CBM_WeightDAL : IBaseDAL<Truck_CBM_Weight>
    {
    }

	public partial interface ITruck_ChargeNameDAL : IBaseDAL<Truck_ChargeName>
    {
    }

	public partial interface ITruck_ClientDAL : IBaseDAL<Truck_Client>
    {
    }

	public partial interface ITruck_CompanyDAL : IBaseDAL<Truck_Company>
    {
    }

	public partial interface ITruck_Delivery_AddressDAL : IBaseDAL<Truck_Delivery_Address>
    {
    }

	public partial interface ITruck_DestDAL : IBaseDAL<Truck_Dest>
    {
    }

	public partial interface ITruck_Exchange_RateDAL : IBaseDAL<Truck_Exchange_Rate>
    {
    }

	public partial interface ITruck_InvoiceDAL : IBaseDAL<Truck_Invoice>
    {
    }

	public partial interface ITruck_Invoice_CodeDAL : IBaseDAL<Truck_Invoice_Code>
    {
    }

	public partial interface ITruck_Invoice_InfoDAL : IBaseDAL<Truck_Invoice_Info>
    {
    }

	public partial interface ITruck_Invoice_Info_AddDAL : IBaseDAL<Truck_Invoice_Info_Add>
    {
    }

	public partial interface ITruck_Loading_AddressDAL : IBaseDAL<Truck_Loading_Address>
    {
    }

	public partial interface ITruck_PackingListDAL : IBaseDAL<Truck_PackingList>
    {
    }

	public partial interface ITruck_PODAL : IBaseDAL<Truck_PO>
    {
    }

	public partial interface ITruck_Storage_YardDAL : IBaseDAL<Truck_Storage_Yard>
    {
    }

	public partial interface ITruck_VendorDAL : IBaseDAL<Truck_Vendor>
    {
    }

	public partial interface ITruck_Vendor_ClientDAL : IBaseDAL<Truck_Vendor_Client>
    {
    }

	public partial interface ITruck_WarehouseDAL : IBaseDAL<Truck_Warehouse>
    {
    }

	public partial interface ITruckUnLoadTimeDAL : IBaseDAL<TruckUnLoadTime>
    {
    }

	public partial interface IturnoverDAL : IBaseDAL<turnover>
    {
    }

	public partial interface IunitDAL : IBaseDAL<unit>
    {
    }

	public partial interface IUnloadingDAL : IBaseDAL<Unloading>
    {
    }

	public partial interface IUser_PasswordDAL : IBaseDAL<User_Password>
    {
    }

	public partial interface IuserlogDAL : IBaseDAL<userlog>
    {
    }

	public partial interface IVehicleDAL : IBaseDAL<Vehicle>
    {
    }

	public partial interface IvendorDAL : IBaseDAL<vendor>
    {
    }

	public partial interface IVendorInfoDAL : IBaseDAL<VendorInfo>
    {
    }

	public partial interface IvesselDAL : IBaseDAL<vessel>
    {
    }

	public partial interface IwhsDAL : IBaseDAL<whs>
    {
    }

	public partial interface IypmfuserDAL : IBaseDAL<ypmfuser>
    {
    }


}