﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
	public partial interface IBLLSession
    {
		IaccountBLL IaccountBLL{get;set;}
		IAccountContInfoBLL IAccountContInfoBLL{get;set;}
		IAdditionalOutBLL IAdditionalOutBLL{get;set;}
		IBasic_Return_AddressBLL IBasic_Return_AddressBLL{get;set;}
		IBn_ZodiacBLL IBn_ZodiacBLL{get;set;}
		IBookingDetailEdiBLL IBookingDetailEdiBLL{get;set;}
		IbookingDtlBLL IbookingDtlBLL{get;set;}
		IbookingForwardBLL IbookingForwardBLL{get;set;}
		IbookingHeadBLL IbookingHeadBLL{get;set;}
		IBookingHeadEdiBLL IBookingHeadEdiBLL{get;set;}
		IbookingUserBLL IbookingUserBLL{get;set;}
		IbookingVendorBLL IbookingVendorBLL{get;set;}
		Icarrier_bookingBLL Icarrier_bookingBLL{get;set;}
		ICarrierInfoBLL ICarrierInfoBLL{get;set;}
		IcategoryBLL IcategoryBLL{get;set;}
		IChargeDEBITNOTEBLL IChargeDEBITNOTEBLL{get;set;}
		IChargeNameBLL IChargeNameBLL{get;set;}
		IClientBLL IClientBLL{get;set;}
		Iclp_chargeListBLL Iclp_chargeListBLL{get;set;}
		IcollectlistBLL IcollectlistBLL{get;set;}
		Icon_sizeBLL Icon_sizeBLL{get;set;}
		IconsigneeBLL IconsigneeBLL{get;set;}
		Icont_addressBLL Icont_addressBLL{get;set;}
		ICont_SizeBLL ICont_SizeBLL{get;set;}
		IContTransFeeBLL IContTransFeeBLL{get;set;}
		ICurr_RateBLL ICurr_RateBLL{get;set;}
		Icus_contBLL Icus_contBLL{get;set;}
		Icus_hchgBLL Icus_hchgBLL{get;set;}
		IcustinBLL IcustinBLL{get;set;}
		IcustinnoBLL IcustinnoBLL{get;set;}
		IcustomerBLL IcustomerBLL{get;set;}
		ICustomer_OrderBLL ICustomer_OrderBLL{get;set;}
		ICustomer_Order_PlanBLL ICustomer_Order_PlanBLL{get;set;}
		Icustomer1BLL Icustomer1BLL{get;set;}
		IcustomsBLL IcustomsBLL{get;set;}
		Icustoms_headBLL Icustoms_headBLL{get;set;}
		Icustoms_itemBLL Icustoms_itemBLL{get;set;}
		Icustoms_outBLL Icustoms_outBLL{get;set;}
		ICustomsTypeBLL ICustomsTypeBLL{get;set;}
		IcustoutnoBLL IcustoutnoBLL{get;set;}
		IDailyCustomsDocuBLL IDailyCustomsDocuBLL{get;set;}
		IDailyDataforCustomsBLL IDailyDataforCustomsBLL{get;set;}
		IDailyTurnoverBLL IDailyTurnoverBLL{get;set;}
		IDebitNoteNoBLL IDebitNoteNoBLL{get;set;}
		Idecl_noBLL Idecl_noBLL{get;set;}
		IdestBLL IdestBLL{get;set;}
		IdestinationBLL IdestinationBLL{get;set;}
		IDestInfo2BLL IDestInfo2BLL{get;set;}
		IDestOfBRSIBLL IDestOfBRSIBLL{get;set;}
		IdobitNoteLogBLL IdobitNoteLogBLL{get;set;}
		IdtpropertiesBLL IdtpropertiesBLL{get;set;}
		IEDIExcptnRegBLL IEDIExcptnRegBLL{get;set;}
		IEmployeesBLL IEmployeesBLL{get;set;}
		IExchange_RateBLL IExchange_RateBLL{get;set;}
		IExclusionCustomsBLL IExclusionCustomsBLL{get;set;}
		IFCR_DetailBLL IFCR_DetailBLL{get;set;}
		IFCR_Discharging_PortBLL IFCR_Discharging_PortBLL{get;set;}
		IFCR_FactoryBLL IFCR_FactoryBLL{get;set;}
		IFCR_HeadBLL IFCR_HeadBLL{get;set;}
		IFCR_SupplierBLL IFCR_SupplierBLL{get;set;}
		IFcrSMBaseChargeBLL IFcrSMBaseChargeBLL{get;set;}
		IFinalLoadingPlanBLL IFinalLoadingPlanBLL{get;set;}
		IFinalLoadingPlan_PaymentBLL IFinalLoadingPlan_PaymentBLL{get;set;}
		IFinalLoadPlanAmazonVendorBLL IFinalLoadPlanAmazonVendorBLL{get;set;}
		IFinalLoadPlanHolidayBLL IFinalLoadPlanHolidayBLL{get;set;}
		IFinalLoadPlanJobRecordBLL IFinalLoadPlanJobRecordBLL{get;set;}
		IFinalLoadPlanRPALogBLL IFinalLoadPlanRPALogBLL{get;set;}
		IFinalPo_Cancel_RecordBLL IFinalPo_Cancel_RecordBLL{get;set;}
		IFinalPoListBLL IFinalPoListBLL{get;set;}
		IFinalVendorInputBLL IFinalVendorInputBLL{get;set;}
		IFinalVendorInputLogBLL IFinalVendorInputLogBLL{get;set;}
		IFinalVendorInputTruckingBLL IFinalVendorInputTruckingBLL{get;set;}
		IfinanceChargeBLL IfinanceChargeBLL{get;set;}
		Iforwarder_codeBLL Iforwarder_codeBLL{get;set;}
		Iin_headBLL Iin_headBLL{get;set;}
		Iin_itemBLL Iin_itemBLL{get;set;}
		IIn2SoBLL IIn2SoBLL{get;set;}
		IInDocContainerBLL IInDocContainerBLL{get;set;}
		IInDocVehicleBLL IInDocVehicleBLL{get;set;}
		IInheadBLL IInheadBLL{get;set;}
		IInListBLL IInListBLL{get;set;}
		IinvoiceBLL IinvoiceBLL{get;set;}
		IinvoiceExchangeBLL IinvoiceExchangeBLL{get;set;}
		IlatecomeBLL IlatecomeBLL{get;set;}
		ILoad_FeeBLL ILoad_FeeBLL{get;set;}
		ILoadingBLL ILoadingBLL{get;set;}
		ILoadPlanUpdateRecordBLL ILoadPlanUpdateRecordBLL{get;set;}
		ILPCont_InfoBLL ILPCont_InfoBLL{get;set;}
		ILPStatusBLL ILPStatusBLL{get;set;}
		IMaxIdBLL IMaxIdBLL{get;set;}
		InewpackingBLL InewpackingBLL{get;set;}
		InewpacklistBLL InewpacklistBLL{get;set;}
		Iout_headBLL Iout_headBLL{get;set;}
		Iout_head_cyBLL Iout_head_cyBLL{get;set;}
		Iout_itemBLL Iout_itemBLL{get;set;}
		Iout_item_cyBLL Iout_item_cyBLL{get;set;}
		IOutDocContainerBLL IOutDocContainerBLL{get;set;}
		IOutDocVehicleBLL IOutDocVehicleBLL{get;set;}
		IOutheadBLL IOutheadBLL{get;set;}
		IOutListBLL IOutListBLL{get;set;}
		IOutListItemsBLL IOutListItemsBLL{get;set;}
		Ipick_return_chargeBLL Ipick_return_chargeBLL{get;set;}
		IPortBLL IPortBLL{get;set;}
		IProdesOfVIFABLL IProdesOfVIFABLL{get;set;}
		Irec_amountBLL Irec_amountBLL{get;set;}
		IrecdtlBLL IrecdtlBLL{get;set;}
		IrecheadBLL IrecheadBLL{get;set;}
		IRecRegistrationHeadBLL IRecRegistrationHeadBLL{get;set;}
		IRecRegistrationItemsBLL IRecRegistrationItemsBLL{get;set;}
		IRecRegVehicleBLL IRecRegVehicleBLL{get;set;}
		IrepertoryBLL IrepertoryBLL{get;set;}
		IserviceBLL IserviceBLL{get;set;}
		IshipcorpBLL IshipcorpBLL{get;set;}
		IShipperNameListBLL IShipperNameListBLL{get;set;}
		IShipToBLL IShipToBLL{get;set;}
		ISMFOBDebitNoteRateAutomaticgrowthBLL ISMFOBDebitNoteRateAutomaticgrowthBLL{get;set;}
		Ispe_opertypeBLL Ispe_opertypeBLL{get;set;}
		IspecialBLL IspecialBLL{get;set;}
		Ispecial_itemBLL Ispecial_itemBLL{get;set;}
		ISpsOperateBLL ISpsOperateBLL{get;set;}
		ISys_DepartmentBLL ISys_DepartmentBLL{get;set;}
		ISys_EasyUIBLL ISys_EasyUIBLL{get;set;}
		ISys_LogBLL ISys_LogBLL{get;set;}
		ISys_PermissionBLL ISys_PermissionBLL{get;set;}
		ISys_RoleBLL ISys_RoleBLL{get;set;}
		ISys_RolePermissionBLL ISys_RolePermissionBLL{get;set;}
		ISys_UserInfoBLL ISys_UserInfoBLL{get;set;}
		ISys_UserRoleBLL ISys_UserRoleBLL{get;set;}
		ISys_UserSettingBLL ISys_UserSettingBLL{get;set;}
		ISys_UserVipPermissionBLL ISys_UserVipPermissionBLL{get;set;}
		IsysdiagramsBLL IsysdiagramsBLL{get;set;}
		ITruck_AccountBLL ITruck_AccountBLL{get;set;}
		ITruck_Account2BLL ITruck_Account2BLL{get;set;}
		ITruck_Booking_ChargeBLL ITruck_Booking_ChargeBLL{get;set;}
		ITruck_Booking_ClientChargeBLL ITruck_Booking_ClientChargeBLL{get;set;}
		ITruck_Booking_DetailBLL ITruck_Booking_DetailBLL{get;set;}
		ITruck_Booking_FileBLL ITruck_Booking_FileBLL{get;set;}
		ITruck_Booking_HeadBLL ITruck_Booking_HeadBLL{get;set;}
		ITruck_Booking_RegBLL ITruck_Booking_RegBLL{get;set;}
		ITruck_CBM_WeightBLL ITruck_CBM_WeightBLL{get;set;}
		ITruck_ChargeNameBLL ITruck_ChargeNameBLL{get;set;}
		ITruck_ClientBLL ITruck_ClientBLL{get;set;}
		ITruck_CompanyBLL ITruck_CompanyBLL{get;set;}
		ITruck_Delivery_AddressBLL ITruck_Delivery_AddressBLL{get;set;}
		ITruck_DestBLL ITruck_DestBLL{get;set;}
		ITruck_Exchange_RateBLL ITruck_Exchange_RateBLL{get;set;}
		ITruck_InvoiceBLL ITruck_InvoiceBLL{get;set;}
		ITruck_Invoice_CodeBLL ITruck_Invoice_CodeBLL{get;set;}
		ITruck_Invoice_InfoBLL ITruck_Invoice_InfoBLL{get;set;}
		ITruck_Invoice_Info_AddBLL ITruck_Invoice_Info_AddBLL{get;set;}
		ITruck_Loading_AddressBLL ITruck_Loading_AddressBLL{get;set;}
		ITruck_PackingListBLL ITruck_PackingListBLL{get;set;}
		ITruck_POBLL ITruck_POBLL{get;set;}
		ITruck_Storage_YardBLL ITruck_Storage_YardBLL{get;set;}
		ITruck_VendorBLL ITruck_VendorBLL{get;set;}
		ITruck_Vendor_ClientBLL ITruck_Vendor_ClientBLL{get;set;}
		ITruck_WarehouseBLL ITruck_WarehouseBLL{get;set;}
		ITruckUnLoadTimeBLL ITruckUnLoadTimeBLL{get;set;}
		IturnoverBLL IturnoverBLL{get;set;}
		IunitBLL IunitBLL{get;set;}
		IUnloadingBLL IUnloadingBLL{get;set;}
		IUser_PasswordBLL IUser_PasswordBLL{get;set;}
		IuserlogBLL IuserlogBLL{get;set;}
		IVehicleBLL IVehicleBLL{get;set;}
		IvendorBLL IvendorBLL{get;set;}
		IVendorInfoBLL IVendorInfoBLL{get;set;}
		IvesselBLL IvesselBLL{get;set;}
		IwhsBLL IwhsBLL{get;set;}
		IypmfuserBLL IypmfuserBLL{get;set;}
    }

}