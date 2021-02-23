 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using IBLL;
namespace BLLMsSql
{
	public partial class accountService : BaseBLL<account>,IaccountBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IaccountDAL;
		}
    }
	public partial class AccountContInfoService : BaseBLL<AccountContInfo>,IAccountContInfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IAccountContInfoDAL;
		}
    }
	public partial class AdditionalOutService : BaseBLL<AdditionalOut>,IAdditionalOutBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IAdditionalOutDAL;
		}
    }
	public partial class Basic_Return_AddressService : BaseBLL<Basic_Return_Address>,IBasic_Return_AddressBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IBasic_Return_AddressDAL;
		}
    }
	public partial class Bn_ZodiacService : BaseBLL<Bn_Zodiac>,IBn_ZodiacBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IBn_ZodiacDAL;
		}
    }
	public partial class BookingDetailEdiService : BaseBLL<BookingDetailEdi>,IBookingDetailEdiBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IBookingDetailEdiDAL;
		}
    }
	public partial class bookingDtlService : BaseBLL<bookingDtl>,IbookingDtlBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IbookingDtlDAL;
		}
    }
	public partial class bookingForwardService : BaseBLL<bookingForward>,IbookingForwardBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IbookingForwardDAL;
		}
    }
	public partial class bookingHeadService : BaseBLL<bookingHead>,IbookingHeadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IbookingHeadDAL;
		}
    }
	public partial class BookingHeadEdiService : BaseBLL<BookingHeadEdi>,IBookingHeadEdiBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IBookingHeadEdiDAL;
		}
    }
	public partial class bookingUserService : BaseBLL<bookingUser>,IbookingUserBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IbookingUserDAL;
		}
    }
	public partial class bookingVendorService : BaseBLL<bookingVendor>,IbookingVendorBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IbookingVendorDAL;
		}
    }
	public partial class carrier_bookingService : BaseBLL<carrier_booking>,Icarrier_bookingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icarrier_bookingDAL;
		}
    }
	public partial class CarrierInfoService : BaseBLL<CarrierInfo>,ICarrierInfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICarrierInfoDAL;
		}
    }
	public partial class categoryService : BaseBLL<category>,IcategoryBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcategoryDAL;
		}
    }
	public partial class ChargeDEBITNOTEService : BaseBLL<ChargeDEBITNOTE>,IChargeDEBITNOTEBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IChargeDEBITNOTEDAL;
		}
    }
	public partial class ChargeNameService : BaseBLL<ChargeName>,IChargeNameBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IChargeNameDAL;
		}
    }
	public partial class ClientService : BaseBLL<Client>,IClientBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IClientDAL;
		}
    }
	public partial class clp_chargeListService : BaseBLL<clp_chargeList>,Iclp_chargeListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iclp_chargeListDAL;
		}
    }
	public partial class collectlistService : BaseBLL<collectlist>,IcollectlistBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcollectlistDAL;
		}
    }
	public partial class con_sizeService : BaseBLL<con_size>,Icon_sizeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icon_sizeDAL;
		}
    }
	public partial class consigneeService : BaseBLL<consignee>,IconsigneeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IconsigneeDAL;
		}
    }
	public partial class cont_addressService : BaseBLL<cont_address>,Icont_addressBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icont_addressDAL;
		}
    }
	public partial class Cont_SizeService : BaseBLL<Cont_Size>,ICont_SizeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICont_SizeDAL;
		}
    }
	public partial class ContTransFeeService : BaseBLL<ContTransFee>,IContTransFeeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IContTransFeeDAL;
		}
    }
	public partial class Curr_RateService : BaseBLL<Curr_Rate>,ICurr_RateBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICurr_RateDAL;
		}
    }
	public partial class cus_contService : BaseBLL<cus_cont>,Icus_contBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icus_contDAL;
		}
    }
	public partial class cus_hchgService : BaseBLL<cus_hchg>,Icus_hchgBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icus_hchgDAL;
		}
    }
	public partial class custinService : BaseBLL<custin>,IcustinBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcustinDAL;
		}
    }
	public partial class custinnoService : BaseBLL<custinno>,IcustinnoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcustinnoDAL;
		}
    }
	public partial class customerService : BaseBLL<customer>,IcustomerBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcustomerDAL;
		}
    }
	public partial class Customer_OrderService : BaseBLL<Customer_Order>,ICustomer_OrderBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICustomer_OrderDAL;
		}
    }
	public partial class Customer_Order_PlanService : BaseBLL<Customer_Order_Plan>,ICustomer_Order_PlanBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICustomer_Order_PlanDAL;
		}
    }
	public partial class customer1Service : BaseBLL<customer1>,Icustomer1BLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icustomer1DAL;
		}
    }
	public partial class customsService : BaseBLL<customs>,IcustomsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcustomsDAL;
		}
    }
	public partial class customs_headService : BaseBLL<customs_head>,Icustoms_headBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icustoms_headDAL;
		}
    }
	public partial class customs_itemService : BaseBLL<customs_item>,Icustoms_itemBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icustoms_itemDAL;
		}
    }
	public partial class customs_outService : BaseBLL<customs_out>,Icustoms_outBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Icustoms_outDAL;
		}
    }
	public partial class CustomsTypeService : BaseBLL<CustomsType>,ICustomsTypeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ICustomsTypeDAL;
		}
    }
	public partial class custoutnoService : BaseBLL<custoutno>,IcustoutnoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IcustoutnoDAL;
		}
    }
	public partial class DailyCustomsDocuService : BaseBLL<DailyCustomsDocu>,IDailyCustomsDocuBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDailyCustomsDocuDAL;
		}
    }
	public partial class DailyDataforCustomsService : BaseBLL<DailyDataforCustoms>,IDailyDataforCustomsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDailyDataforCustomsDAL;
		}
    }
	public partial class DailyTurnoverService : BaseBLL<DailyTurnover>,IDailyTurnoverBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDailyTurnoverDAL;
		}
    }
	public partial class DebitNoteNoService : BaseBLL<DebitNoteNo>,IDebitNoteNoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDebitNoteNoDAL;
		}
    }
	public partial class decl_noService : BaseBLL<decl_no>,Idecl_noBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Idecl_noDAL;
		}
    }
	public partial class destService : BaseBLL<dest>,IdestBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IdestDAL;
		}
    }
	public partial class destinationService : BaseBLL<destination>,IdestinationBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IdestinationDAL;
		}
    }
	public partial class DestInfo2Service : BaseBLL<DestInfo2>,IDestInfo2BLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDestInfo2DAL;
		}
    }
	public partial class DestOfBRSIService : BaseBLL<DestOfBRSI>,IDestOfBRSIBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IDestOfBRSIDAL;
		}
    }
	public partial class dobitNoteLogService : BaseBLL<dobitNoteLog>,IdobitNoteLogBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IdobitNoteLogDAL;
		}
    }
	public partial class dtpropertiesService : BaseBLL<dtproperties>,IdtpropertiesBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IdtpropertiesDAL;
		}
    }
	public partial class EDIExcptnRegService : BaseBLL<EDIExcptnReg>,IEDIExcptnRegBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IEDIExcptnRegDAL;
		}
    }
	public partial class EmployeesService : BaseBLL<Employees>,IEmployeesBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IEmployeesDAL;
		}
    }
	public partial class Exchange_RateService : BaseBLL<Exchange_Rate>,IExchange_RateBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IExchange_RateDAL;
		}
    }
	public partial class ExclusionCustomsService : BaseBLL<ExclusionCustoms>,IExclusionCustomsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IExclusionCustomsDAL;
		}
    }
	public partial class FCR_DetailService : BaseBLL<FCR_Detail>,IFCR_DetailBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFCR_DetailDAL;
		}
    }
	public partial class FCR_Discharging_PortService : BaseBLL<FCR_Discharging_Port>,IFCR_Discharging_PortBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFCR_Discharging_PortDAL;
		}
    }
	public partial class FCR_FactoryService : BaseBLL<FCR_Factory>,IFCR_FactoryBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFCR_FactoryDAL;
		}
    }
	public partial class FCR_HeadService : BaseBLL<FCR_Head>,IFCR_HeadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFCR_HeadDAL;
		}
    }
	public partial class FCR_SupplierService : BaseBLL<FCR_Supplier>,IFCR_SupplierBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFCR_SupplierDAL;
		}
    }
	public partial class FcrSMBaseChargeService : BaseBLL<FcrSMBaseCharge>,IFcrSMBaseChargeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFcrSMBaseChargeDAL;
		}
    }
	public partial class FinalLoadingPlanService : BaseBLL<FinalLoadingPlan>,IFinalLoadingPlanBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadingPlanDAL;
		}
    }
	public partial class FinalLoadingPlan_PaymentService : BaseBLL<FinalLoadingPlan_Payment>,IFinalLoadingPlan_PaymentBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadingPlan_PaymentDAL;
		}
    }
	public partial class FinalLoadPlanAmazonVendorService : BaseBLL<FinalLoadPlanAmazonVendor>,IFinalLoadPlanAmazonVendorBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadPlanAmazonVendorDAL;
		}
    }
	public partial class FinalLoadPlanHolidayService : BaseBLL<FinalLoadPlanHoliday>,IFinalLoadPlanHolidayBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadPlanHolidayDAL;
		}
    }
	public partial class FinalLoadPlanJobRecordService : BaseBLL<FinalLoadPlanJobRecord>,IFinalLoadPlanJobRecordBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadPlanJobRecordDAL;
		}
    }
	public partial class FinalLoadPlanRPALogService : BaseBLL<FinalLoadPlanRPALog>,IFinalLoadPlanRPALogBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalLoadPlanRPALogDAL;
		}
    }
	public partial class FinalPo_Cancel_RecordService : BaseBLL<FinalPo_Cancel_Record>,IFinalPo_Cancel_RecordBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalPo_Cancel_RecordDAL;
		}
    }
	public partial class FinalPoListService : BaseBLL<FinalPoList>,IFinalPoListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalPoListDAL;
		}
    }
	public partial class FinalVendorInputService : BaseBLL<FinalVendorInput>,IFinalVendorInputBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalVendorInputDAL;
		}
    }
	public partial class FinalVendorInputLogService : BaseBLL<FinalVendorInputLog>,IFinalVendorInputLogBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalVendorInputLogDAL;
		}
    }
	public partial class FinalVendorInputTruckingService : BaseBLL<FinalVendorInputTrucking>,IFinalVendorInputTruckingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IFinalVendorInputTruckingDAL;
		}
    }
	public partial class financeChargeService : BaseBLL<financeCharge>,IfinanceChargeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IfinanceChargeDAL;
		}
    }
	public partial class forwarder_codeService : BaseBLL<forwarder_code>,Iforwarder_codeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iforwarder_codeDAL;
		}
    }
	public partial class in_headService : BaseBLL<in_head>,Iin_headBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iin_headDAL;
		}
    }
	public partial class in_itemService : BaseBLL<in_item>,Iin_itemBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iin_itemDAL;
		}
    }
	public partial class In2SoService : BaseBLL<In2So>,IIn2SoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IIn2SoDAL;
		}
    }
	public partial class InDocContainerService : BaseBLL<InDocContainer>,IInDocContainerBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IInDocContainerDAL;
		}
    }
	public partial class InDocVehicleService : BaseBLL<InDocVehicle>,IInDocVehicleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IInDocVehicleDAL;
		}
    }
	public partial class InheadService : BaseBLL<Inhead>,IInheadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IInheadDAL;
		}
    }
	public partial class InListService : BaseBLL<InList>,IInListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IInListDAL;
		}
    }
	public partial class invoiceService : BaseBLL<invoice>,IinvoiceBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IinvoiceDAL;
		}
    }
	public partial class invoiceExchangeService : BaseBLL<invoiceExchange>,IinvoiceExchangeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IinvoiceExchangeDAL;
		}
    }
	public partial class latecomeService : BaseBLL<latecome>,IlatecomeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IlatecomeDAL;
		}
    }
	public partial class Load_FeeService : BaseBLL<Load_Fee>,ILoad_FeeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ILoad_FeeDAL;
		}
    }
	public partial class LoadingService : BaseBLL<Loading>,ILoadingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ILoadingDAL;
		}
    }
	public partial class LoadPlanUpdateRecordService : BaseBLL<LoadPlanUpdateRecord>,ILoadPlanUpdateRecordBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ILoadPlanUpdateRecordDAL;
		}
    }
	public partial class LPCont_InfoService : BaseBLL<LPCont_Info>,ILPCont_InfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ILPCont_InfoDAL;
		}
    }
	public partial class LPStatusService : BaseBLL<LPStatus>,ILPStatusBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ILPStatusDAL;
		}
    }
	public partial class MaxIdService : BaseBLL<MaxId>,IMaxIdBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IMaxIdDAL;
		}
    }
	public partial class newpackingService : BaseBLL<newpacking>,InewpackingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.InewpackingDAL;
		}
    }
	public partial class newpacklistService : BaseBLL<newpacklist>,InewpacklistBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.InewpacklistDAL;
		}
    }
	public partial class out_headService : BaseBLL<out_head>,Iout_headBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iout_headDAL;
		}
    }
	public partial class out_head_cyService : BaseBLL<out_head_cy>,Iout_head_cyBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iout_head_cyDAL;
		}
    }
	public partial class out_itemService : BaseBLL<out_item>,Iout_itemBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iout_itemDAL;
		}
    }
	public partial class out_item_cyService : BaseBLL<out_item_cy>,Iout_item_cyBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Iout_item_cyDAL;
		}
    }
	public partial class OutDocContainerService : BaseBLL<OutDocContainer>,IOutDocContainerBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IOutDocContainerDAL;
		}
    }
	public partial class OutDocVehicleService : BaseBLL<OutDocVehicle>,IOutDocVehicleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IOutDocVehicleDAL;
		}
    }
	public partial class OutheadService : BaseBLL<Outhead>,IOutheadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IOutheadDAL;
		}
    }
	public partial class OutListService : BaseBLL<OutList>,IOutListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IOutListDAL;
		}
    }
	public partial class OutListItemsService : BaseBLL<OutListItems>,IOutListItemsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IOutListItemsDAL;
		}
    }
	public partial class pick_return_chargeService : BaseBLL<pick_return_charge>,Ipick_return_chargeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Ipick_return_chargeDAL;
		}
    }
	public partial class PortService : BaseBLL<Port>,IPortBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IPortDAL;
		}
    }
	public partial class ProdesOfVIFAService : BaseBLL<ProdesOfVIFA>,IProdesOfVIFABLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IProdesOfVIFADAL;
		}
    }
	public partial class rec_amountService : BaseBLL<rec_amount>,Irec_amountBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Irec_amountDAL;
		}
    }
	public partial class recdtlService : BaseBLL<recdtl>,IrecdtlBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IrecdtlDAL;
		}
    }
	public partial class recheadService : BaseBLL<rechead>,IrecheadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IrecheadDAL;
		}
    }
	public partial class RecRegistrationHeadService : BaseBLL<RecRegistrationHead>,IRecRegistrationHeadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IRecRegistrationHeadDAL;
		}
    }
	public partial class RecRegistrationItemsService : BaseBLL<RecRegistrationItems>,IRecRegistrationItemsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IRecRegistrationItemsDAL;
		}
    }
	public partial class RecRegVehicleService : BaseBLL<RecRegVehicle>,IRecRegVehicleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IRecRegVehicleDAL;
		}
    }
	public partial class repertoryService : BaseBLL<repertory>,IrepertoryBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IrepertoryDAL;
		}
    }
	public partial class serviceService : BaseBLL<service>,IserviceBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IserviceDAL;
		}
    }
	public partial class shipcorpService : BaseBLL<shipcorp>,IshipcorpBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IshipcorpDAL;
		}
    }
	public partial class ShipperNameListService : BaseBLL<ShipperNameList>,IShipperNameListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IShipperNameListDAL;
		}
    }
	public partial class ShipToService : BaseBLL<ShipTo>,IShipToBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IShipToDAL;
		}
    }
	public partial class SMFOBDebitNoteRateAutomaticgrowthService : BaseBLL<SMFOBDebitNoteRateAutomaticgrowth>,ISMFOBDebitNoteRateAutomaticgrowthBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISMFOBDebitNoteRateAutomaticgrowthDAL;
		}
    }
	public partial class spe_opertypeService : BaseBLL<spe_opertype>,Ispe_opertypeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Ispe_opertypeDAL;
		}
    }
	public partial class specialService : BaseBLL<special>,IspecialBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IspecialDAL;
		}
    }
	public partial class special_itemService : BaseBLL<special_item>,Ispecial_itemBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.Ispecial_itemDAL;
		}
    }
	public partial class SpsOperateService : BaseBLL<SpsOperate>,ISpsOperateBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISpsOperateDAL;
		}
    }
	public partial class Sys_DepartmentService : BaseBLL<Sys_Department>,ISys_DepartmentBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_DepartmentDAL;
		}
    }
	public partial class Sys_EasyUIService : BaseBLL<Sys_EasyUI>,ISys_EasyUIBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_EasyUIDAL;
		}
    }
	public partial class Sys_LogService : BaseBLL<Sys_Log>,ISys_LogBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_LogDAL;
		}
    }
	public partial class Sys_PermissionService : BaseBLL<Sys_Permission>,ISys_PermissionBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_PermissionDAL;
		}
    }
	public partial class Sys_RoleService : BaseBLL<Sys_Role>,ISys_RoleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_RoleDAL;
		}
    }
	public partial class Sys_RolePermissionService : BaseBLL<Sys_RolePermission>,ISys_RolePermissionBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_RolePermissionDAL;
		}
    }
	public partial class Sys_UserInfoService : BaseBLL<Sys_UserInfo>,ISys_UserInfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_UserInfoDAL;
		}
    }
	public partial class Sys_UserRoleService : BaseBLL<Sys_UserRole>,ISys_UserRoleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_UserRoleDAL;
		}
    }
	public partial class Sys_UserSettingService : BaseBLL<Sys_UserSetting>,ISys_UserSettingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_UserSettingDAL;
		}
    }
	public partial class Sys_UserVipPermissionService : BaseBLL<Sys_UserVipPermission>,ISys_UserVipPermissionBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISys_UserVipPermissionDAL;
		}
    }
	public partial class sysdiagramsService : BaseBLL<sysdiagrams>,IsysdiagramsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IsysdiagramsDAL;
		}
    }
	public partial class Truck_AccountService : BaseBLL<Truck_Account>,ITruck_AccountBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_AccountDAL;
		}
    }
	public partial class Truck_Account2Service : BaseBLL<Truck_Account2>,ITruck_Account2BLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Account2DAL;
		}
    }
	public partial class Truck_Booking_ChargeService : BaseBLL<Truck_Booking_Charge>,ITruck_Booking_ChargeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_ChargeDAL;
		}
    }
	public partial class Truck_Booking_ClientChargeService : BaseBLL<Truck_Booking_ClientCharge>,ITruck_Booking_ClientChargeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_ClientChargeDAL;
		}
    }
	public partial class Truck_Booking_DetailService : BaseBLL<Truck_Booking_Detail>,ITruck_Booking_DetailBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_DetailDAL;
		}
    }
	public partial class Truck_Booking_FileService : BaseBLL<Truck_Booking_File>,ITruck_Booking_FileBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_FileDAL;
		}
    }
	public partial class Truck_Booking_HeadService : BaseBLL<Truck_Booking_Head>,ITruck_Booking_HeadBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_HeadDAL;
		}
    }
	public partial class Truck_Booking_RegService : BaseBLL<Truck_Booking_Reg>,ITruck_Booking_RegBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Booking_RegDAL;
		}
    }
	public partial class Truck_CBM_WeightService : BaseBLL<Truck_CBM_Weight>,ITruck_CBM_WeightBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_CBM_WeightDAL;
		}
    }
	public partial class Truck_ChargeNameService : BaseBLL<Truck_ChargeName>,ITruck_ChargeNameBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_ChargeNameDAL;
		}
    }
	public partial class Truck_ClientService : BaseBLL<Truck_Client>,ITruck_ClientBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_ClientDAL;
		}
    }
	public partial class Truck_CompanyService : BaseBLL<Truck_Company>,ITruck_CompanyBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_CompanyDAL;
		}
    }
	public partial class Truck_Delivery_AddressService : BaseBLL<Truck_Delivery_Address>,ITruck_Delivery_AddressBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Delivery_AddressDAL;
		}
    }
	public partial class Truck_DestService : BaseBLL<Truck_Dest>,ITruck_DestBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_DestDAL;
		}
    }
	public partial class Truck_Exchange_RateService : BaseBLL<Truck_Exchange_Rate>,ITruck_Exchange_RateBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Exchange_RateDAL;
		}
    }
	public partial class Truck_InvoiceService : BaseBLL<Truck_Invoice>,ITruck_InvoiceBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_InvoiceDAL;
		}
    }
	public partial class Truck_Invoice_CodeService : BaseBLL<Truck_Invoice_Code>,ITruck_Invoice_CodeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Invoice_CodeDAL;
		}
    }
	public partial class Truck_Invoice_InfoService : BaseBLL<Truck_Invoice_Info>,ITruck_Invoice_InfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Invoice_InfoDAL;
		}
    }
	public partial class Truck_Invoice_Info_AddService : BaseBLL<Truck_Invoice_Info_Add>,ITruck_Invoice_Info_AddBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Invoice_Info_AddDAL;
		}
    }
	public partial class Truck_Loading_AddressService : BaseBLL<Truck_Loading_Address>,ITruck_Loading_AddressBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Loading_AddressDAL;
		}
    }
	public partial class Truck_PackingListService : BaseBLL<Truck_PackingList>,ITruck_PackingListBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_PackingListDAL;
		}
    }
	public partial class Truck_POService : BaseBLL<Truck_PO>,ITruck_POBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_PODAL;
		}
    }
	public partial class Truck_Storage_YardService : BaseBLL<Truck_Storage_Yard>,ITruck_Storage_YardBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Storage_YardDAL;
		}
    }
	public partial class Truck_VendorService : BaseBLL<Truck_Vendor>,ITruck_VendorBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_VendorDAL;
		}
    }
	public partial class Truck_Vendor_ClientService : BaseBLL<Truck_Vendor_Client>,ITruck_Vendor_ClientBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_Vendor_ClientDAL;
		}
    }
	public partial class Truck_WarehouseService : BaseBLL<Truck_Warehouse>,ITruck_WarehouseBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruck_WarehouseDAL;
		}
    }
	public partial class TruckUnLoadTimeService : BaseBLL<TruckUnLoadTime>,ITruckUnLoadTimeBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ITruckUnLoadTimeDAL;
		}
    }
	public partial class turnoverService : BaseBLL<turnover>,IturnoverBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IturnoverDAL;
		}
    }
	public partial class unitService : BaseBLL<unit>,IunitBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IunitDAL;
		}
    }
	public partial class UnloadingService : BaseBLL<Unloading>,IUnloadingBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IUnloadingDAL;
		}
    }
	public partial class User_PasswordService : BaseBLL<User_Password>,IUser_PasswordBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IUser_PasswordDAL;
		}
    }
	public partial class userlogService : BaseBLL<userlog>,IuserlogBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IuserlogDAL;
		}
    }
	public partial class VehicleService : BaseBLL<Vehicle>,IVehicleBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IVehicleDAL;
		}
    }
	public partial class vendorService : BaseBLL<vendor>,IvendorBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IvendorDAL;
		}
    }
	public partial class VendorInfoService : BaseBLL<VendorInfo>,IVendorInfoBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IVendorInfoDAL;
		}
    }
	public partial class vesselService : BaseBLL<vessel>,IvesselBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IvesselDAL;
		}
    }
	public partial class whsService : BaseBLL<whs>,IwhsBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IwhsDAL;
		}
    }
	public partial class ypmfuserService : BaseBLL<ypmfuser>,IypmfuserBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.IypmfuserDAL;
		}
    }
}