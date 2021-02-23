
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALMsSql
{
	public partial class DBSession:IDBSession
    {
		#region 01 数据接口 IaccountDAL
		IaccountDAL iaccountDAL;
		public IaccountDAL IaccountDAL
		{
			get
			{
				if(iaccountDAL==null)
					iaccountDAL= new accountDAL();
				return iaccountDAL;
			}
			set
			{
				iaccountDAL= value;
			}
		}
		#endregion

		#region 02 数据接口 IAccountContInfoDAL
		IAccountContInfoDAL iAccountContInfoDAL;
		public IAccountContInfoDAL IAccountContInfoDAL
		{
			get
			{
				if(iAccountContInfoDAL==null)
					iAccountContInfoDAL= new AccountContInfoDAL();
				return iAccountContInfoDAL;
			}
			set
			{
				iAccountContInfoDAL= value;
			}
		}
		#endregion

		#region 03 数据接口 IAdditionalOutDAL
		IAdditionalOutDAL iAdditionalOutDAL;
		public IAdditionalOutDAL IAdditionalOutDAL
		{
			get
			{
				if(iAdditionalOutDAL==null)
					iAdditionalOutDAL= new AdditionalOutDAL();
				return iAdditionalOutDAL;
			}
			set
			{
				iAdditionalOutDAL= value;
			}
		}
		#endregion

		#region 04 数据接口 IBasic_Return_AddressDAL
		IBasic_Return_AddressDAL iBasic_Return_AddressDAL;
		public IBasic_Return_AddressDAL IBasic_Return_AddressDAL
		{
			get
			{
				if(iBasic_Return_AddressDAL==null)
					iBasic_Return_AddressDAL= new Basic_Return_AddressDAL();
				return iBasic_Return_AddressDAL;
			}
			set
			{
				iBasic_Return_AddressDAL= value;
			}
		}
		#endregion

		#region 05 数据接口 IBn_ZodiacDAL
		IBn_ZodiacDAL iBn_ZodiacDAL;
		public IBn_ZodiacDAL IBn_ZodiacDAL
		{
			get
			{
				if(iBn_ZodiacDAL==null)
					iBn_ZodiacDAL= new Bn_ZodiacDAL();
				return iBn_ZodiacDAL;
			}
			set
			{
				iBn_ZodiacDAL= value;
			}
		}
		#endregion

		#region 06 数据接口 IBookingDetailEdiDAL
		IBookingDetailEdiDAL iBookingDetailEdiDAL;
		public IBookingDetailEdiDAL IBookingDetailEdiDAL
		{
			get
			{
				if(iBookingDetailEdiDAL==null)
					iBookingDetailEdiDAL= new BookingDetailEdiDAL();
				return iBookingDetailEdiDAL;
			}
			set
			{
				iBookingDetailEdiDAL= value;
			}
		}
		#endregion

		#region 07 数据接口 IbookingDtlDAL
		IbookingDtlDAL ibookingDtlDAL;
		public IbookingDtlDAL IbookingDtlDAL
		{
			get
			{
				if(ibookingDtlDAL==null)
					ibookingDtlDAL= new bookingDtlDAL();
				return ibookingDtlDAL;
			}
			set
			{
				ibookingDtlDAL= value;
			}
		}
		#endregion

		#region 08 数据接口 IbookingForwardDAL
		IbookingForwardDAL ibookingForwardDAL;
		public IbookingForwardDAL IbookingForwardDAL
		{
			get
			{
				if(ibookingForwardDAL==null)
					ibookingForwardDAL= new bookingForwardDAL();
				return ibookingForwardDAL;
			}
			set
			{
				ibookingForwardDAL= value;
			}
		}
		#endregion

		#region 09 数据接口 IbookingHeadDAL
		IbookingHeadDAL ibookingHeadDAL;
		public IbookingHeadDAL IbookingHeadDAL
		{
			get
			{
				if(ibookingHeadDAL==null)
					ibookingHeadDAL= new bookingHeadDAL();
				return ibookingHeadDAL;
			}
			set
			{
				ibookingHeadDAL= value;
			}
		}
		#endregion

		#region 10 数据接口 IBookingHeadEdiDAL
		IBookingHeadEdiDAL iBookingHeadEdiDAL;
		public IBookingHeadEdiDAL IBookingHeadEdiDAL
		{
			get
			{
				if(iBookingHeadEdiDAL==null)
					iBookingHeadEdiDAL= new BookingHeadEdiDAL();
				return iBookingHeadEdiDAL;
			}
			set
			{
				iBookingHeadEdiDAL= value;
			}
		}
		#endregion

		#region 11 数据接口 IbookingUserDAL
		IbookingUserDAL ibookingUserDAL;
		public IbookingUserDAL IbookingUserDAL
		{
			get
			{
				if(ibookingUserDAL==null)
					ibookingUserDAL= new bookingUserDAL();
				return ibookingUserDAL;
			}
			set
			{
				ibookingUserDAL= value;
			}
		}
		#endregion

		#region 12 数据接口 IbookingVendorDAL
		IbookingVendorDAL ibookingVendorDAL;
		public IbookingVendorDAL IbookingVendorDAL
		{
			get
			{
				if(ibookingVendorDAL==null)
					ibookingVendorDAL= new bookingVendorDAL();
				return ibookingVendorDAL;
			}
			set
			{
				ibookingVendorDAL= value;
			}
		}
		#endregion

		#region 13 数据接口 Icarrier_bookingDAL
		Icarrier_bookingDAL icarrier_bookingDAL;
		public Icarrier_bookingDAL Icarrier_bookingDAL
		{
			get
			{
				if(icarrier_bookingDAL==null)
					icarrier_bookingDAL= new carrier_bookingDAL();
				return icarrier_bookingDAL;
			}
			set
			{
				icarrier_bookingDAL= value;
			}
		}
		#endregion

		#region 14 数据接口 ICarrierInfoDAL
		ICarrierInfoDAL iCarrierInfoDAL;
		public ICarrierInfoDAL ICarrierInfoDAL
		{
			get
			{
				if(iCarrierInfoDAL==null)
					iCarrierInfoDAL= new CarrierInfoDAL();
				return iCarrierInfoDAL;
			}
			set
			{
				iCarrierInfoDAL= value;
			}
		}
		#endregion

		#region 15 数据接口 IcategoryDAL
		IcategoryDAL icategoryDAL;
		public IcategoryDAL IcategoryDAL
		{
			get
			{
				if(icategoryDAL==null)
					icategoryDAL= new categoryDAL();
				return icategoryDAL;
			}
			set
			{
				icategoryDAL= value;
			}
		}
		#endregion

		#region 16 数据接口 IChargeDEBITNOTEDAL
		IChargeDEBITNOTEDAL iChargeDEBITNOTEDAL;
		public IChargeDEBITNOTEDAL IChargeDEBITNOTEDAL
		{
			get
			{
				if(iChargeDEBITNOTEDAL==null)
					iChargeDEBITNOTEDAL= new ChargeDEBITNOTEDAL();
				return iChargeDEBITNOTEDAL;
			}
			set
			{
				iChargeDEBITNOTEDAL= value;
			}
		}
		#endregion

		#region 17 数据接口 IChargeNameDAL
		IChargeNameDAL iChargeNameDAL;
		public IChargeNameDAL IChargeNameDAL
		{
			get
			{
				if(iChargeNameDAL==null)
					iChargeNameDAL= new ChargeNameDAL();
				return iChargeNameDAL;
			}
			set
			{
				iChargeNameDAL= value;
			}
		}
		#endregion

		#region 18 数据接口 IClientDAL
		IClientDAL iClientDAL;
		public IClientDAL IClientDAL
		{
			get
			{
				if(iClientDAL==null)
					iClientDAL= new ClientDAL();
				return iClientDAL;
			}
			set
			{
				iClientDAL= value;
			}
		}
		#endregion

		#region 19 数据接口 Iclp_chargeListDAL
		Iclp_chargeListDAL iclp_chargeListDAL;
		public Iclp_chargeListDAL Iclp_chargeListDAL
		{
			get
			{
				if(iclp_chargeListDAL==null)
					iclp_chargeListDAL= new clp_chargeListDAL();
				return iclp_chargeListDAL;
			}
			set
			{
				iclp_chargeListDAL= value;
			}
		}
		#endregion

		#region 20 数据接口 IcollectlistDAL
		IcollectlistDAL icollectlistDAL;
		public IcollectlistDAL IcollectlistDAL
		{
			get
			{
				if(icollectlistDAL==null)
					icollectlistDAL= new collectlistDAL();
				return icollectlistDAL;
			}
			set
			{
				icollectlistDAL= value;
			}
		}
		#endregion

		#region 21 数据接口 Icon_sizeDAL
		Icon_sizeDAL icon_sizeDAL;
		public Icon_sizeDAL Icon_sizeDAL
		{
			get
			{
				if(icon_sizeDAL==null)
					icon_sizeDAL= new con_sizeDAL();
				return icon_sizeDAL;
			}
			set
			{
				icon_sizeDAL= value;
			}
		}
		#endregion

		#region 22 数据接口 IconsigneeDAL
		IconsigneeDAL iconsigneeDAL;
		public IconsigneeDAL IconsigneeDAL
		{
			get
			{
				if(iconsigneeDAL==null)
					iconsigneeDAL= new consigneeDAL();
				return iconsigneeDAL;
			}
			set
			{
				iconsigneeDAL= value;
			}
		}
		#endregion

		#region 23 数据接口 Icont_addressDAL
		Icont_addressDAL icont_addressDAL;
		public Icont_addressDAL Icont_addressDAL
		{
			get
			{
				if(icont_addressDAL==null)
					icont_addressDAL= new cont_addressDAL();
				return icont_addressDAL;
			}
			set
			{
				icont_addressDAL= value;
			}
		}
		#endregion

		#region 24 数据接口 ICont_SizeDAL
		ICont_SizeDAL iCont_SizeDAL;
		public ICont_SizeDAL ICont_SizeDAL
		{
			get
			{
				if(iCont_SizeDAL==null)
					iCont_SizeDAL= new Cont_SizeDAL();
				return iCont_SizeDAL;
			}
			set
			{
				iCont_SizeDAL= value;
			}
		}
		#endregion

		#region 25 数据接口 IContTransFeeDAL
		IContTransFeeDAL iContTransFeeDAL;
		public IContTransFeeDAL IContTransFeeDAL
		{
			get
			{
				if(iContTransFeeDAL==null)
					iContTransFeeDAL= new ContTransFeeDAL();
				return iContTransFeeDAL;
			}
			set
			{
				iContTransFeeDAL= value;
			}
		}
		#endregion

		#region 26 数据接口 ICurr_RateDAL
		ICurr_RateDAL iCurr_RateDAL;
		public ICurr_RateDAL ICurr_RateDAL
		{
			get
			{
				if(iCurr_RateDAL==null)
					iCurr_RateDAL= new Curr_RateDAL();
				return iCurr_RateDAL;
			}
			set
			{
				iCurr_RateDAL= value;
			}
		}
		#endregion

		#region 27 数据接口 Icus_contDAL
		Icus_contDAL icus_contDAL;
		public Icus_contDAL Icus_contDAL
		{
			get
			{
				if(icus_contDAL==null)
					icus_contDAL= new cus_contDAL();
				return icus_contDAL;
			}
			set
			{
				icus_contDAL= value;
			}
		}
		#endregion

		#region 28 数据接口 Icus_hchgDAL
		Icus_hchgDAL icus_hchgDAL;
		public Icus_hchgDAL Icus_hchgDAL
		{
			get
			{
				if(icus_hchgDAL==null)
					icus_hchgDAL= new cus_hchgDAL();
				return icus_hchgDAL;
			}
			set
			{
				icus_hchgDAL= value;
			}
		}
		#endregion

		#region 29 数据接口 IcustinDAL
		IcustinDAL icustinDAL;
		public IcustinDAL IcustinDAL
		{
			get
			{
				if(icustinDAL==null)
					icustinDAL= new custinDAL();
				return icustinDAL;
			}
			set
			{
				icustinDAL= value;
			}
		}
		#endregion

		#region 30 数据接口 IcustinnoDAL
		IcustinnoDAL icustinnoDAL;
		public IcustinnoDAL IcustinnoDAL
		{
			get
			{
				if(icustinnoDAL==null)
					icustinnoDAL= new custinnoDAL();
				return icustinnoDAL;
			}
			set
			{
				icustinnoDAL= value;
			}
		}
		#endregion

		#region 31 数据接口 IcustomerDAL
		IcustomerDAL icustomerDAL;
		public IcustomerDAL IcustomerDAL
		{
			get
			{
				if(icustomerDAL==null)
					icustomerDAL= new customerDAL();
				return icustomerDAL;
			}
			set
			{
				icustomerDAL= value;
			}
		}
		#endregion

		#region 32 数据接口 ICustomer_OrderDAL
		ICustomer_OrderDAL iCustomer_OrderDAL;
		public ICustomer_OrderDAL ICustomer_OrderDAL
		{
			get
			{
				if(iCustomer_OrderDAL==null)
					iCustomer_OrderDAL= new Customer_OrderDAL();
				return iCustomer_OrderDAL;
			}
			set
			{
				iCustomer_OrderDAL= value;
			}
		}
		#endregion

		#region 33 数据接口 ICustomer_Order_PlanDAL
		ICustomer_Order_PlanDAL iCustomer_Order_PlanDAL;
		public ICustomer_Order_PlanDAL ICustomer_Order_PlanDAL
		{
			get
			{
				if(iCustomer_Order_PlanDAL==null)
					iCustomer_Order_PlanDAL= new Customer_Order_PlanDAL();
				return iCustomer_Order_PlanDAL;
			}
			set
			{
				iCustomer_Order_PlanDAL= value;
			}
		}
		#endregion

		#region 34 数据接口 Icustomer1DAL
		Icustomer1DAL icustomer1DAL;
		public Icustomer1DAL Icustomer1DAL
		{
			get
			{
				if(icustomer1DAL==null)
					icustomer1DAL= new customer1DAL();
				return icustomer1DAL;
			}
			set
			{
				icustomer1DAL= value;
			}
		}
		#endregion

		#region 35 数据接口 IcustomsDAL
		IcustomsDAL icustomsDAL;
		public IcustomsDAL IcustomsDAL
		{
			get
			{
				if(icustomsDAL==null)
					icustomsDAL= new customsDAL();
				return icustomsDAL;
			}
			set
			{
				icustomsDAL= value;
			}
		}
		#endregion

		#region 36 数据接口 Icustoms_headDAL
		Icustoms_headDAL icustoms_headDAL;
		public Icustoms_headDAL Icustoms_headDAL
		{
			get
			{
				if(icustoms_headDAL==null)
					icustoms_headDAL= new customs_headDAL();
				return icustoms_headDAL;
			}
			set
			{
				icustoms_headDAL= value;
			}
		}
		#endregion

		#region 37 数据接口 Icustoms_itemDAL
		Icustoms_itemDAL icustoms_itemDAL;
		public Icustoms_itemDAL Icustoms_itemDAL
		{
			get
			{
				if(icustoms_itemDAL==null)
					icustoms_itemDAL= new customs_itemDAL();
				return icustoms_itemDAL;
			}
			set
			{
				icustoms_itemDAL= value;
			}
		}
		#endregion

		#region 38 数据接口 Icustoms_outDAL
		Icustoms_outDAL icustoms_outDAL;
		public Icustoms_outDAL Icustoms_outDAL
		{
			get
			{
				if(icustoms_outDAL==null)
					icustoms_outDAL= new customs_outDAL();
				return icustoms_outDAL;
			}
			set
			{
				icustoms_outDAL= value;
			}
		}
		#endregion

		#region 39 数据接口 ICustomsTypeDAL
		ICustomsTypeDAL iCustomsTypeDAL;
		public ICustomsTypeDAL ICustomsTypeDAL
		{
			get
			{
				if(iCustomsTypeDAL==null)
					iCustomsTypeDAL= new CustomsTypeDAL();
				return iCustomsTypeDAL;
			}
			set
			{
				iCustomsTypeDAL= value;
			}
		}
		#endregion

		#region 40 数据接口 IcustoutnoDAL
		IcustoutnoDAL icustoutnoDAL;
		public IcustoutnoDAL IcustoutnoDAL
		{
			get
			{
				if(icustoutnoDAL==null)
					icustoutnoDAL= new custoutnoDAL();
				return icustoutnoDAL;
			}
			set
			{
				icustoutnoDAL= value;
			}
		}
		#endregion

		#region 41 数据接口 IDailyCustomsDocuDAL
		IDailyCustomsDocuDAL iDailyCustomsDocuDAL;
		public IDailyCustomsDocuDAL IDailyCustomsDocuDAL
		{
			get
			{
				if(iDailyCustomsDocuDAL==null)
					iDailyCustomsDocuDAL= new DailyCustomsDocuDAL();
				return iDailyCustomsDocuDAL;
			}
			set
			{
				iDailyCustomsDocuDAL= value;
			}
		}
		#endregion

		#region 42 数据接口 IDailyDataforCustomsDAL
		IDailyDataforCustomsDAL iDailyDataforCustomsDAL;
		public IDailyDataforCustomsDAL IDailyDataforCustomsDAL
		{
			get
			{
				if(iDailyDataforCustomsDAL==null)
					iDailyDataforCustomsDAL= new DailyDataforCustomsDAL();
				return iDailyDataforCustomsDAL;
			}
			set
			{
				iDailyDataforCustomsDAL= value;
			}
		}
		#endregion

		#region 43 数据接口 IDailyTurnoverDAL
		IDailyTurnoverDAL iDailyTurnoverDAL;
		public IDailyTurnoverDAL IDailyTurnoverDAL
		{
			get
			{
				if(iDailyTurnoverDAL==null)
					iDailyTurnoverDAL= new DailyTurnoverDAL();
				return iDailyTurnoverDAL;
			}
			set
			{
				iDailyTurnoverDAL= value;
			}
		}
		#endregion

		#region 44 数据接口 IDebitNoteNoDAL
		IDebitNoteNoDAL iDebitNoteNoDAL;
		public IDebitNoteNoDAL IDebitNoteNoDAL
		{
			get
			{
				if(iDebitNoteNoDAL==null)
					iDebitNoteNoDAL= new DebitNoteNoDAL();
				return iDebitNoteNoDAL;
			}
			set
			{
				iDebitNoteNoDAL= value;
			}
		}
		#endregion

		#region 45 数据接口 Idecl_noDAL
		Idecl_noDAL idecl_noDAL;
		public Idecl_noDAL Idecl_noDAL
		{
			get
			{
				if(idecl_noDAL==null)
					idecl_noDAL= new decl_noDAL();
				return idecl_noDAL;
			}
			set
			{
				idecl_noDAL= value;
			}
		}
		#endregion

		#region 46 数据接口 IdestDAL
		IdestDAL idestDAL;
		public IdestDAL IdestDAL
		{
			get
			{
				if(idestDAL==null)
					idestDAL= new destDAL();
				return idestDAL;
			}
			set
			{
				idestDAL= value;
			}
		}
		#endregion

		#region 47 数据接口 IdestinationDAL
		IdestinationDAL idestinationDAL;
		public IdestinationDAL IdestinationDAL
		{
			get
			{
				if(idestinationDAL==null)
					idestinationDAL= new destinationDAL();
				return idestinationDAL;
			}
			set
			{
				idestinationDAL= value;
			}
		}
		#endregion

		#region 48 数据接口 IDestInfo2DAL
		IDestInfo2DAL iDestInfo2DAL;
		public IDestInfo2DAL IDestInfo2DAL
		{
			get
			{
				if(iDestInfo2DAL==null)
					iDestInfo2DAL= new DestInfo2DAL();
				return iDestInfo2DAL;
			}
			set
			{
				iDestInfo2DAL= value;
			}
		}
		#endregion

		#region 49 数据接口 IDestOfBRSIDAL
		IDestOfBRSIDAL iDestOfBRSIDAL;
		public IDestOfBRSIDAL IDestOfBRSIDAL
		{
			get
			{
				if(iDestOfBRSIDAL==null)
					iDestOfBRSIDAL= new DestOfBRSIDAL();
				return iDestOfBRSIDAL;
			}
			set
			{
				iDestOfBRSIDAL= value;
			}
		}
		#endregion

		#region 50 数据接口 IdobitNoteLogDAL
		IdobitNoteLogDAL idobitNoteLogDAL;
		public IdobitNoteLogDAL IdobitNoteLogDAL
		{
			get
			{
				if(idobitNoteLogDAL==null)
					idobitNoteLogDAL= new dobitNoteLogDAL();
				return idobitNoteLogDAL;
			}
			set
			{
				idobitNoteLogDAL= value;
			}
		}
		#endregion

		#region 51 数据接口 IdtpropertiesDAL
		IdtpropertiesDAL idtpropertiesDAL;
		public IdtpropertiesDAL IdtpropertiesDAL
		{
			get
			{
				if(idtpropertiesDAL==null)
					idtpropertiesDAL= new dtpropertiesDAL();
				return idtpropertiesDAL;
			}
			set
			{
				idtpropertiesDAL= value;
			}
		}
		#endregion

		#region 52 数据接口 IEDIExcptnRegDAL
		IEDIExcptnRegDAL iEDIExcptnRegDAL;
		public IEDIExcptnRegDAL IEDIExcptnRegDAL
		{
			get
			{
				if(iEDIExcptnRegDAL==null)
					iEDIExcptnRegDAL= new EDIExcptnRegDAL();
				return iEDIExcptnRegDAL;
			}
			set
			{
				iEDIExcptnRegDAL= value;
			}
		}
		#endregion

		#region 53 数据接口 IEmployeesDAL
		IEmployeesDAL iEmployeesDAL;
		public IEmployeesDAL IEmployeesDAL
		{
			get
			{
				if(iEmployeesDAL==null)
					iEmployeesDAL= new EmployeesDAL();
				return iEmployeesDAL;
			}
			set
			{
				iEmployeesDAL= value;
			}
		}
		#endregion

		#region 54 数据接口 IExchange_RateDAL
		IExchange_RateDAL iExchange_RateDAL;
		public IExchange_RateDAL IExchange_RateDAL
		{
			get
			{
				if(iExchange_RateDAL==null)
					iExchange_RateDAL= new Exchange_RateDAL();
				return iExchange_RateDAL;
			}
			set
			{
				iExchange_RateDAL= value;
			}
		}
		#endregion

		#region 55 数据接口 IExclusionCustomsDAL
		IExclusionCustomsDAL iExclusionCustomsDAL;
		public IExclusionCustomsDAL IExclusionCustomsDAL
		{
			get
			{
				if(iExclusionCustomsDAL==null)
					iExclusionCustomsDAL= new ExclusionCustomsDAL();
				return iExclusionCustomsDAL;
			}
			set
			{
				iExclusionCustomsDAL= value;
			}
		}
		#endregion

		#region 56 数据接口 IFCR_DetailDAL
		IFCR_DetailDAL iFCR_DetailDAL;
		public IFCR_DetailDAL IFCR_DetailDAL
		{
			get
			{
				if(iFCR_DetailDAL==null)
					iFCR_DetailDAL= new FCR_DetailDAL();
				return iFCR_DetailDAL;
			}
			set
			{
				iFCR_DetailDAL= value;
			}
		}
		#endregion

		#region 57 数据接口 IFCR_Discharging_PortDAL
		IFCR_Discharging_PortDAL iFCR_Discharging_PortDAL;
		public IFCR_Discharging_PortDAL IFCR_Discharging_PortDAL
		{
			get
			{
				if(iFCR_Discharging_PortDAL==null)
					iFCR_Discharging_PortDAL= new FCR_Discharging_PortDAL();
				return iFCR_Discharging_PortDAL;
			}
			set
			{
				iFCR_Discharging_PortDAL= value;
			}
		}
		#endregion

		#region 58 数据接口 IFCR_FactoryDAL
		IFCR_FactoryDAL iFCR_FactoryDAL;
		public IFCR_FactoryDAL IFCR_FactoryDAL
		{
			get
			{
				if(iFCR_FactoryDAL==null)
					iFCR_FactoryDAL= new FCR_FactoryDAL();
				return iFCR_FactoryDAL;
			}
			set
			{
				iFCR_FactoryDAL= value;
			}
		}
		#endregion

		#region 59 数据接口 IFCR_HeadDAL
		IFCR_HeadDAL iFCR_HeadDAL;
		public IFCR_HeadDAL IFCR_HeadDAL
		{
			get
			{
				if(iFCR_HeadDAL==null)
					iFCR_HeadDAL= new FCR_HeadDAL();
				return iFCR_HeadDAL;
			}
			set
			{
				iFCR_HeadDAL= value;
			}
		}
		#endregion

		#region 60 数据接口 IFCR_SupplierDAL
		IFCR_SupplierDAL iFCR_SupplierDAL;
		public IFCR_SupplierDAL IFCR_SupplierDAL
		{
			get
			{
				if(iFCR_SupplierDAL==null)
					iFCR_SupplierDAL= new FCR_SupplierDAL();
				return iFCR_SupplierDAL;
			}
			set
			{
				iFCR_SupplierDAL= value;
			}
		}
		#endregion

		#region 61 数据接口 IFcrSMBaseChargeDAL
		IFcrSMBaseChargeDAL iFcrSMBaseChargeDAL;
		public IFcrSMBaseChargeDAL IFcrSMBaseChargeDAL
		{
			get
			{
				if(iFcrSMBaseChargeDAL==null)
					iFcrSMBaseChargeDAL= new FcrSMBaseChargeDAL();
				return iFcrSMBaseChargeDAL;
			}
			set
			{
				iFcrSMBaseChargeDAL= value;
			}
		}
		#endregion

		#region 62 数据接口 IFinalLoadingPlanDAL
		IFinalLoadingPlanDAL iFinalLoadingPlanDAL;
		public IFinalLoadingPlanDAL IFinalLoadingPlanDAL
		{
			get
			{
				if(iFinalLoadingPlanDAL==null)
					iFinalLoadingPlanDAL= new FinalLoadingPlanDAL();
				return iFinalLoadingPlanDAL;
			}
			set
			{
				iFinalLoadingPlanDAL= value;
			}
		}
		#endregion

		#region 63 数据接口 IFinalLoadingPlan_PaymentDAL
		IFinalLoadingPlan_PaymentDAL iFinalLoadingPlan_PaymentDAL;
		public IFinalLoadingPlan_PaymentDAL IFinalLoadingPlan_PaymentDAL
		{
			get
			{
				if(iFinalLoadingPlan_PaymentDAL==null)
					iFinalLoadingPlan_PaymentDAL= new FinalLoadingPlan_PaymentDAL();
				return iFinalLoadingPlan_PaymentDAL;
			}
			set
			{
				iFinalLoadingPlan_PaymentDAL= value;
			}
		}
		#endregion

		#region 64 数据接口 IFinalLoadPlanAmazonVendorDAL
		IFinalLoadPlanAmazonVendorDAL iFinalLoadPlanAmazonVendorDAL;
		public IFinalLoadPlanAmazonVendorDAL IFinalLoadPlanAmazonVendorDAL
		{
			get
			{
				if(iFinalLoadPlanAmazonVendorDAL==null)
					iFinalLoadPlanAmazonVendorDAL= new FinalLoadPlanAmazonVendorDAL();
				return iFinalLoadPlanAmazonVendorDAL;
			}
			set
			{
				iFinalLoadPlanAmazonVendorDAL= value;
			}
		}
		#endregion

		#region 65 数据接口 IFinalLoadPlanHolidayDAL
		IFinalLoadPlanHolidayDAL iFinalLoadPlanHolidayDAL;
		public IFinalLoadPlanHolidayDAL IFinalLoadPlanHolidayDAL
		{
			get
			{
				if(iFinalLoadPlanHolidayDAL==null)
					iFinalLoadPlanHolidayDAL= new FinalLoadPlanHolidayDAL();
				return iFinalLoadPlanHolidayDAL;
			}
			set
			{
				iFinalLoadPlanHolidayDAL= value;
			}
		}
		#endregion

		#region 66 数据接口 IFinalLoadPlanJobRecordDAL
		IFinalLoadPlanJobRecordDAL iFinalLoadPlanJobRecordDAL;
		public IFinalLoadPlanJobRecordDAL IFinalLoadPlanJobRecordDAL
		{
			get
			{
				if(iFinalLoadPlanJobRecordDAL==null)
					iFinalLoadPlanJobRecordDAL= new FinalLoadPlanJobRecordDAL();
				return iFinalLoadPlanJobRecordDAL;
			}
			set
			{
				iFinalLoadPlanJobRecordDAL= value;
			}
		}
		#endregion

		#region 67 数据接口 IFinalLoadPlanRPALogDAL
		IFinalLoadPlanRPALogDAL iFinalLoadPlanRPALogDAL;
		public IFinalLoadPlanRPALogDAL IFinalLoadPlanRPALogDAL
		{
			get
			{
				if(iFinalLoadPlanRPALogDAL==null)
					iFinalLoadPlanRPALogDAL= new FinalLoadPlanRPALogDAL();
				return iFinalLoadPlanRPALogDAL;
			}
			set
			{
				iFinalLoadPlanRPALogDAL= value;
			}
		}
		#endregion

		#region 68 数据接口 IFinalPo_Cancel_RecordDAL
		IFinalPo_Cancel_RecordDAL iFinalPo_Cancel_RecordDAL;
		public IFinalPo_Cancel_RecordDAL IFinalPo_Cancel_RecordDAL
		{
			get
			{
				if(iFinalPo_Cancel_RecordDAL==null)
					iFinalPo_Cancel_RecordDAL= new FinalPo_Cancel_RecordDAL();
				return iFinalPo_Cancel_RecordDAL;
			}
			set
			{
				iFinalPo_Cancel_RecordDAL= value;
			}
		}
		#endregion

		#region 69 数据接口 IFinalPoListDAL
		IFinalPoListDAL iFinalPoListDAL;
		public IFinalPoListDAL IFinalPoListDAL
		{
			get
			{
				if(iFinalPoListDAL==null)
					iFinalPoListDAL= new FinalPoListDAL();
				return iFinalPoListDAL;
			}
			set
			{
				iFinalPoListDAL= value;
			}
		}
		#endregion

		#region 70 数据接口 IFinalVendorInputDAL
		IFinalVendorInputDAL iFinalVendorInputDAL;
		public IFinalVendorInputDAL IFinalVendorInputDAL
		{
			get
			{
				if(iFinalVendorInputDAL==null)
					iFinalVendorInputDAL= new FinalVendorInputDAL();
				return iFinalVendorInputDAL;
			}
			set
			{
				iFinalVendorInputDAL= value;
			}
		}
		#endregion

		#region 71 数据接口 IFinalVendorInputLogDAL
		IFinalVendorInputLogDAL iFinalVendorInputLogDAL;
		public IFinalVendorInputLogDAL IFinalVendorInputLogDAL
		{
			get
			{
				if(iFinalVendorInputLogDAL==null)
					iFinalVendorInputLogDAL= new FinalVendorInputLogDAL();
				return iFinalVendorInputLogDAL;
			}
			set
			{
				iFinalVendorInputLogDAL= value;
			}
		}
		#endregion

		#region 72 数据接口 IFinalVendorInputTruckingDAL
		IFinalVendorInputTruckingDAL iFinalVendorInputTruckingDAL;
		public IFinalVendorInputTruckingDAL IFinalVendorInputTruckingDAL
		{
			get
			{
				if(iFinalVendorInputTruckingDAL==null)
					iFinalVendorInputTruckingDAL= new FinalVendorInputTruckingDAL();
				return iFinalVendorInputTruckingDAL;
			}
			set
			{
				iFinalVendorInputTruckingDAL= value;
			}
		}
		#endregion

		#region 73 数据接口 IfinanceChargeDAL
		IfinanceChargeDAL ifinanceChargeDAL;
		public IfinanceChargeDAL IfinanceChargeDAL
		{
			get
			{
				if(ifinanceChargeDAL==null)
					ifinanceChargeDAL= new financeChargeDAL();
				return ifinanceChargeDAL;
			}
			set
			{
				ifinanceChargeDAL= value;
			}
		}
		#endregion

		#region 74 数据接口 Iforwarder_codeDAL
		Iforwarder_codeDAL iforwarder_codeDAL;
		public Iforwarder_codeDAL Iforwarder_codeDAL
		{
			get
			{
				if(iforwarder_codeDAL==null)
					iforwarder_codeDAL= new forwarder_codeDAL();
				return iforwarder_codeDAL;
			}
			set
			{
				iforwarder_codeDAL= value;
			}
		}
		#endregion

		#region 75 数据接口 Iin_headDAL
		Iin_headDAL iin_headDAL;
		public Iin_headDAL Iin_headDAL
		{
			get
			{
				if(iin_headDAL==null)
					iin_headDAL= new in_headDAL();
				return iin_headDAL;
			}
			set
			{
				iin_headDAL= value;
			}
		}
		#endregion

		#region 76 数据接口 Iin_itemDAL
		Iin_itemDAL iin_itemDAL;
		public Iin_itemDAL Iin_itemDAL
		{
			get
			{
				if(iin_itemDAL==null)
					iin_itemDAL= new in_itemDAL();
				return iin_itemDAL;
			}
			set
			{
				iin_itemDAL= value;
			}
		}
		#endregion

		#region 77 数据接口 IIn2SoDAL
		IIn2SoDAL iIn2SoDAL;
		public IIn2SoDAL IIn2SoDAL
		{
			get
			{
				if(iIn2SoDAL==null)
					iIn2SoDAL= new In2SoDAL();
				return iIn2SoDAL;
			}
			set
			{
				iIn2SoDAL= value;
			}
		}
		#endregion

		#region 78 数据接口 IInDocContainerDAL
		IInDocContainerDAL iInDocContainerDAL;
		public IInDocContainerDAL IInDocContainerDAL
		{
			get
			{
				if(iInDocContainerDAL==null)
					iInDocContainerDAL= new InDocContainerDAL();
				return iInDocContainerDAL;
			}
			set
			{
				iInDocContainerDAL= value;
			}
		}
		#endregion

		#region 79 数据接口 IInDocVehicleDAL
		IInDocVehicleDAL iInDocVehicleDAL;
		public IInDocVehicleDAL IInDocVehicleDAL
		{
			get
			{
				if(iInDocVehicleDAL==null)
					iInDocVehicleDAL= new InDocVehicleDAL();
				return iInDocVehicleDAL;
			}
			set
			{
				iInDocVehicleDAL= value;
			}
		}
		#endregion

		#region 80 数据接口 IInheadDAL
		IInheadDAL iInheadDAL;
		public IInheadDAL IInheadDAL
		{
			get
			{
				if(iInheadDAL==null)
					iInheadDAL= new InheadDAL();
				return iInheadDAL;
			}
			set
			{
				iInheadDAL= value;
			}
		}
		#endregion

		#region 81 数据接口 IInListDAL
		IInListDAL iInListDAL;
		public IInListDAL IInListDAL
		{
			get
			{
				if(iInListDAL==null)
					iInListDAL= new InListDAL();
				return iInListDAL;
			}
			set
			{
				iInListDAL= value;
			}
		}
		#endregion

		#region 82 数据接口 IinvoiceDAL
		IinvoiceDAL iinvoiceDAL;
		public IinvoiceDAL IinvoiceDAL
		{
			get
			{
				if(iinvoiceDAL==null)
					iinvoiceDAL= new invoiceDAL();
				return iinvoiceDAL;
			}
			set
			{
				iinvoiceDAL= value;
			}
		}
		#endregion

		#region 83 数据接口 IinvoiceExchangeDAL
		IinvoiceExchangeDAL iinvoiceExchangeDAL;
		public IinvoiceExchangeDAL IinvoiceExchangeDAL
		{
			get
			{
				if(iinvoiceExchangeDAL==null)
					iinvoiceExchangeDAL= new invoiceExchangeDAL();
				return iinvoiceExchangeDAL;
			}
			set
			{
				iinvoiceExchangeDAL= value;
			}
		}
		#endregion

		#region 84 数据接口 IlatecomeDAL
		IlatecomeDAL ilatecomeDAL;
		public IlatecomeDAL IlatecomeDAL
		{
			get
			{
				if(ilatecomeDAL==null)
					ilatecomeDAL= new latecomeDAL();
				return ilatecomeDAL;
			}
			set
			{
				ilatecomeDAL= value;
			}
		}
		#endregion

		#region 85 数据接口 ILoad_FeeDAL
		ILoad_FeeDAL iLoad_FeeDAL;
		public ILoad_FeeDAL ILoad_FeeDAL
		{
			get
			{
				if(iLoad_FeeDAL==null)
					iLoad_FeeDAL= new Load_FeeDAL();
				return iLoad_FeeDAL;
			}
			set
			{
				iLoad_FeeDAL= value;
			}
		}
		#endregion

		#region 86 数据接口 ILoadingDAL
		ILoadingDAL iLoadingDAL;
		public ILoadingDAL ILoadingDAL
		{
			get
			{
				if(iLoadingDAL==null)
					iLoadingDAL= new LoadingDAL();
				return iLoadingDAL;
			}
			set
			{
				iLoadingDAL= value;
			}
		}
		#endregion

		#region 87 数据接口 ILoadPlanUpdateRecordDAL
		ILoadPlanUpdateRecordDAL iLoadPlanUpdateRecordDAL;
		public ILoadPlanUpdateRecordDAL ILoadPlanUpdateRecordDAL
		{
			get
			{
				if(iLoadPlanUpdateRecordDAL==null)
					iLoadPlanUpdateRecordDAL= new LoadPlanUpdateRecordDAL();
				return iLoadPlanUpdateRecordDAL;
			}
			set
			{
				iLoadPlanUpdateRecordDAL= value;
			}
		}
		#endregion

		#region 88 数据接口 ILPCont_InfoDAL
		ILPCont_InfoDAL iLPCont_InfoDAL;
		public ILPCont_InfoDAL ILPCont_InfoDAL
		{
			get
			{
				if(iLPCont_InfoDAL==null)
					iLPCont_InfoDAL= new LPCont_InfoDAL();
				return iLPCont_InfoDAL;
			}
			set
			{
				iLPCont_InfoDAL= value;
			}
		}
		#endregion

		#region 89 数据接口 ILPStatusDAL
		ILPStatusDAL iLPStatusDAL;
		public ILPStatusDAL ILPStatusDAL
		{
			get
			{
				if(iLPStatusDAL==null)
					iLPStatusDAL= new LPStatusDAL();
				return iLPStatusDAL;
			}
			set
			{
				iLPStatusDAL= value;
			}
		}
		#endregion

		#region 90 数据接口 IMaxIdDAL
		IMaxIdDAL iMaxIdDAL;
		public IMaxIdDAL IMaxIdDAL
		{
			get
			{
				if(iMaxIdDAL==null)
					iMaxIdDAL= new MaxIdDAL();
				return iMaxIdDAL;
			}
			set
			{
				iMaxIdDAL= value;
			}
		}
		#endregion

		#region 91 数据接口 InewpackingDAL
		InewpackingDAL inewpackingDAL;
		public InewpackingDAL InewpackingDAL
		{
			get
			{
				if(inewpackingDAL==null)
					inewpackingDAL= new newpackingDAL();
				return inewpackingDAL;
			}
			set
			{
				inewpackingDAL= value;
			}
		}
		#endregion

		#region 92 数据接口 InewpacklistDAL
		InewpacklistDAL inewpacklistDAL;
		public InewpacklistDAL InewpacklistDAL
		{
			get
			{
				if(inewpacklistDAL==null)
					inewpacklistDAL= new newpacklistDAL();
				return inewpacklistDAL;
			}
			set
			{
				inewpacklistDAL= value;
			}
		}
		#endregion

		#region 93 数据接口 Iout_headDAL
		Iout_headDAL iout_headDAL;
		public Iout_headDAL Iout_headDAL
		{
			get
			{
				if(iout_headDAL==null)
					iout_headDAL= new out_headDAL();
				return iout_headDAL;
			}
			set
			{
				iout_headDAL= value;
			}
		}
		#endregion

		#region 94 数据接口 Iout_head_cyDAL
		Iout_head_cyDAL iout_head_cyDAL;
		public Iout_head_cyDAL Iout_head_cyDAL
		{
			get
			{
				if(iout_head_cyDAL==null)
					iout_head_cyDAL= new out_head_cyDAL();
				return iout_head_cyDAL;
			}
			set
			{
				iout_head_cyDAL= value;
			}
		}
		#endregion

		#region 95 数据接口 Iout_itemDAL
		Iout_itemDAL iout_itemDAL;
		public Iout_itemDAL Iout_itemDAL
		{
			get
			{
				if(iout_itemDAL==null)
					iout_itemDAL= new out_itemDAL();
				return iout_itemDAL;
			}
			set
			{
				iout_itemDAL= value;
			}
		}
		#endregion

		#region 96 数据接口 Iout_item_cyDAL
		Iout_item_cyDAL iout_item_cyDAL;
		public Iout_item_cyDAL Iout_item_cyDAL
		{
			get
			{
				if(iout_item_cyDAL==null)
					iout_item_cyDAL= new out_item_cyDAL();
				return iout_item_cyDAL;
			}
			set
			{
				iout_item_cyDAL= value;
			}
		}
		#endregion

		#region 97 数据接口 IOutDocContainerDAL
		IOutDocContainerDAL iOutDocContainerDAL;
		public IOutDocContainerDAL IOutDocContainerDAL
		{
			get
			{
				if(iOutDocContainerDAL==null)
					iOutDocContainerDAL= new OutDocContainerDAL();
				return iOutDocContainerDAL;
			}
			set
			{
				iOutDocContainerDAL= value;
			}
		}
		#endregion

		#region 98 数据接口 IOutDocVehicleDAL
		IOutDocVehicleDAL iOutDocVehicleDAL;
		public IOutDocVehicleDAL IOutDocVehicleDAL
		{
			get
			{
				if(iOutDocVehicleDAL==null)
					iOutDocVehicleDAL= new OutDocVehicleDAL();
				return iOutDocVehicleDAL;
			}
			set
			{
				iOutDocVehicleDAL= value;
			}
		}
		#endregion

		#region 99 数据接口 IOutheadDAL
		IOutheadDAL iOutheadDAL;
		public IOutheadDAL IOutheadDAL
		{
			get
			{
				if(iOutheadDAL==null)
					iOutheadDAL= new OutheadDAL();
				return iOutheadDAL;
			}
			set
			{
				iOutheadDAL= value;
			}
		}
		#endregion

		#region 100 数据接口 IOutListDAL
		IOutListDAL iOutListDAL;
		public IOutListDAL IOutListDAL
		{
			get
			{
				if(iOutListDAL==null)
					iOutListDAL= new OutListDAL();
				return iOutListDAL;
			}
			set
			{
				iOutListDAL= value;
			}
		}
		#endregion

		#region 101 数据接口 IOutListItemsDAL
		IOutListItemsDAL iOutListItemsDAL;
		public IOutListItemsDAL IOutListItemsDAL
		{
			get
			{
				if(iOutListItemsDAL==null)
					iOutListItemsDAL= new OutListItemsDAL();
				return iOutListItemsDAL;
			}
			set
			{
				iOutListItemsDAL= value;
			}
		}
		#endregion

		#region 102 数据接口 Ipick_return_chargeDAL
		Ipick_return_chargeDAL ipick_return_chargeDAL;
		public Ipick_return_chargeDAL Ipick_return_chargeDAL
		{
			get
			{
				if(ipick_return_chargeDAL==null)
					ipick_return_chargeDAL= new pick_return_chargeDAL();
				return ipick_return_chargeDAL;
			}
			set
			{
				ipick_return_chargeDAL= value;
			}
		}
		#endregion

		#region 103 数据接口 IPortDAL
		IPortDAL iPortDAL;
		public IPortDAL IPortDAL
		{
			get
			{
				if(iPortDAL==null)
					iPortDAL= new PortDAL();
				return iPortDAL;
			}
			set
			{
				iPortDAL= value;
			}
		}
		#endregion

		#region 104 数据接口 IProdesOfVIFADAL
		IProdesOfVIFADAL iProdesOfVIFADAL;
		public IProdesOfVIFADAL IProdesOfVIFADAL
		{
			get
			{
				if(iProdesOfVIFADAL==null)
					iProdesOfVIFADAL= new ProdesOfVIFADAL();
				return iProdesOfVIFADAL;
			}
			set
			{
				iProdesOfVIFADAL= value;
			}
		}
		#endregion

		#region 105 数据接口 Irec_amountDAL
		Irec_amountDAL irec_amountDAL;
		public Irec_amountDAL Irec_amountDAL
		{
			get
			{
				if(irec_amountDAL==null)
					irec_amountDAL= new rec_amountDAL();
				return irec_amountDAL;
			}
			set
			{
				irec_amountDAL= value;
			}
		}
		#endregion

		#region 106 数据接口 IrecdtlDAL
		IrecdtlDAL irecdtlDAL;
		public IrecdtlDAL IrecdtlDAL
		{
			get
			{
				if(irecdtlDAL==null)
					irecdtlDAL= new recdtlDAL();
				return irecdtlDAL;
			}
			set
			{
				irecdtlDAL= value;
			}
		}
		#endregion

		#region 107 数据接口 IrecheadDAL
		IrecheadDAL irecheadDAL;
		public IrecheadDAL IrecheadDAL
		{
			get
			{
				if(irecheadDAL==null)
					irecheadDAL= new recheadDAL();
				return irecheadDAL;
			}
			set
			{
				irecheadDAL= value;
			}
		}
		#endregion

		#region 108 数据接口 IRecRegistrationHeadDAL
		IRecRegistrationHeadDAL iRecRegistrationHeadDAL;
		public IRecRegistrationHeadDAL IRecRegistrationHeadDAL
		{
			get
			{
				if(iRecRegistrationHeadDAL==null)
					iRecRegistrationHeadDAL= new RecRegistrationHeadDAL();
				return iRecRegistrationHeadDAL;
			}
			set
			{
				iRecRegistrationHeadDAL= value;
			}
		}
		#endregion

		#region 109 数据接口 IRecRegistrationItemsDAL
		IRecRegistrationItemsDAL iRecRegistrationItemsDAL;
		public IRecRegistrationItemsDAL IRecRegistrationItemsDAL
		{
			get
			{
				if(iRecRegistrationItemsDAL==null)
					iRecRegistrationItemsDAL= new RecRegistrationItemsDAL();
				return iRecRegistrationItemsDAL;
			}
			set
			{
				iRecRegistrationItemsDAL= value;
			}
		}
		#endregion

		#region 110 数据接口 IRecRegVehicleDAL
		IRecRegVehicleDAL iRecRegVehicleDAL;
		public IRecRegVehicleDAL IRecRegVehicleDAL
		{
			get
			{
				if(iRecRegVehicleDAL==null)
					iRecRegVehicleDAL= new RecRegVehicleDAL();
				return iRecRegVehicleDAL;
			}
			set
			{
				iRecRegVehicleDAL= value;
			}
		}
		#endregion

		#region 111 数据接口 IrepertoryDAL
		IrepertoryDAL irepertoryDAL;
		public IrepertoryDAL IrepertoryDAL
		{
			get
			{
				if(irepertoryDAL==null)
					irepertoryDAL= new repertoryDAL();
				return irepertoryDAL;
			}
			set
			{
				irepertoryDAL= value;
			}
		}
		#endregion

		#region 112 数据接口 IserviceDAL
		IserviceDAL iserviceDAL;
		public IserviceDAL IserviceDAL
		{
			get
			{
				if(iserviceDAL==null)
					iserviceDAL= new serviceDAL();
				return iserviceDAL;
			}
			set
			{
				iserviceDAL= value;
			}
		}
		#endregion

		#region 113 数据接口 IshipcorpDAL
		IshipcorpDAL ishipcorpDAL;
		public IshipcorpDAL IshipcorpDAL
		{
			get
			{
				if(ishipcorpDAL==null)
					ishipcorpDAL= new shipcorpDAL();
				return ishipcorpDAL;
			}
			set
			{
				ishipcorpDAL= value;
			}
		}
		#endregion

		#region 114 数据接口 IShipperNameListDAL
		IShipperNameListDAL iShipperNameListDAL;
		public IShipperNameListDAL IShipperNameListDAL
		{
			get
			{
				if(iShipperNameListDAL==null)
					iShipperNameListDAL= new ShipperNameListDAL();
				return iShipperNameListDAL;
			}
			set
			{
				iShipperNameListDAL= value;
			}
		}
		#endregion

		#region 115 数据接口 IShipToDAL
		IShipToDAL iShipToDAL;
		public IShipToDAL IShipToDAL
		{
			get
			{
				if(iShipToDAL==null)
					iShipToDAL= new ShipToDAL();
				return iShipToDAL;
			}
			set
			{
				iShipToDAL= value;
			}
		}
		#endregion

		#region 116 数据接口 ISMFOBDebitNoteRateAutomaticgrowthDAL
		ISMFOBDebitNoteRateAutomaticgrowthDAL iSMFOBDebitNoteRateAutomaticgrowthDAL;
		public ISMFOBDebitNoteRateAutomaticgrowthDAL ISMFOBDebitNoteRateAutomaticgrowthDAL
		{
			get
			{
				if(iSMFOBDebitNoteRateAutomaticgrowthDAL==null)
					iSMFOBDebitNoteRateAutomaticgrowthDAL= new SMFOBDebitNoteRateAutomaticgrowthDAL();
				return iSMFOBDebitNoteRateAutomaticgrowthDAL;
			}
			set
			{
				iSMFOBDebitNoteRateAutomaticgrowthDAL= value;
			}
		}
		#endregion

		#region 117 数据接口 Ispe_opertypeDAL
		Ispe_opertypeDAL ispe_opertypeDAL;
		public Ispe_opertypeDAL Ispe_opertypeDAL
		{
			get
			{
				if(ispe_opertypeDAL==null)
					ispe_opertypeDAL= new spe_opertypeDAL();
				return ispe_opertypeDAL;
			}
			set
			{
				ispe_opertypeDAL= value;
			}
		}
		#endregion

		#region 118 数据接口 IspecialDAL
		IspecialDAL ispecialDAL;
		public IspecialDAL IspecialDAL
		{
			get
			{
				if(ispecialDAL==null)
					ispecialDAL= new specialDAL();
				return ispecialDAL;
			}
			set
			{
				ispecialDAL= value;
			}
		}
		#endregion

		#region 119 数据接口 Ispecial_itemDAL
		Ispecial_itemDAL ispecial_itemDAL;
		public Ispecial_itemDAL Ispecial_itemDAL
		{
			get
			{
				if(ispecial_itemDAL==null)
					ispecial_itemDAL= new special_itemDAL();
				return ispecial_itemDAL;
			}
			set
			{
				ispecial_itemDAL= value;
			}
		}
		#endregion

		#region 120 数据接口 ISpsOperateDAL
		ISpsOperateDAL iSpsOperateDAL;
		public ISpsOperateDAL ISpsOperateDAL
		{
			get
			{
				if(iSpsOperateDAL==null)
					iSpsOperateDAL= new SpsOperateDAL();
				return iSpsOperateDAL;
			}
			set
			{
				iSpsOperateDAL= value;
			}
		}
		#endregion

		#region 121 数据接口 ISys_DepartmentDAL
		ISys_DepartmentDAL iSys_DepartmentDAL;
		public ISys_DepartmentDAL ISys_DepartmentDAL
		{
			get
			{
				if(iSys_DepartmentDAL==null)
					iSys_DepartmentDAL= new Sys_DepartmentDAL();
				return iSys_DepartmentDAL;
			}
			set
			{
				iSys_DepartmentDAL= value;
			}
		}
		#endregion

		#region 122 数据接口 ISys_EasyUIDAL
		ISys_EasyUIDAL iSys_EasyUIDAL;
		public ISys_EasyUIDAL ISys_EasyUIDAL
		{
			get
			{
				if(iSys_EasyUIDAL==null)
					iSys_EasyUIDAL= new Sys_EasyUIDAL();
				return iSys_EasyUIDAL;
			}
			set
			{
				iSys_EasyUIDAL= value;
			}
		}
		#endregion

		#region 123 数据接口 ISys_LogDAL
		ISys_LogDAL iSys_LogDAL;
		public ISys_LogDAL ISys_LogDAL
		{
			get
			{
				if(iSys_LogDAL==null)
					iSys_LogDAL= new Sys_LogDAL();
				return iSys_LogDAL;
			}
			set
			{
				iSys_LogDAL= value;
			}
		}
		#endregion

		#region 124 数据接口 ISys_PermissionDAL
		ISys_PermissionDAL iSys_PermissionDAL;
		public ISys_PermissionDAL ISys_PermissionDAL
		{
			get
			{
				if(iSys_PermissionDAL==null)
					iSys_PermissionDAL= new Sys_PermissionDAL();
				return iSys_PermissionDAL;
			}
			set
			{
				iSys_PermissionDAL= value;
			}
		}
		#endregion

		#region 125 数据接口 ISys_RoleDAL
		ISys_RoleDAL iSys_RoleDAL;
		public ISys_RoleDAL ISys_RoleDAL
		{
			get
			{
				if(iSys_RoleDAL==null)
					iSys_RoleDAL= new Sys_RoleDAL();
				return iSys_RoleDAL;
			}
			set
			{
				iSys_RoleDAL= value;
			}
		}
		#endregion

		#region 126 数据接口 ISys_RolePermissionDAL
		ISys_RolePermissionDAL iSys_RolePermissionDAL;
		public ISys_RolePermissionDAL ISys_RolePermissionDAL
		{
			get
			{
				if(iSys_RolePermissionDAL==null)
					iSys_RolePermissionDAL= new Sys_RolePermissionDAL();
				return iSys_RolePermissionDAL;
			}
			set
			{
				iSys_RolePermissionDAL= value;
			}
		}
		#endregion

		#region 127 数据接口 ISys_UserInfoDAL
		ISys_UserInfoDAL iSys_UserInfoDAL;
		public ISys_UserInfoDAL ISys_UserInfoDAL
		{
			get
			{
				if(iSys_UserInfoDAL==null)
					iSys_UserInfoDAL= new Sys_UserInfoDAL();
				return iSys_UserInfoDAL;
			}
			set
			{
				iSys_UserInfoDAL= value;
			}
		}
		#endregion

		#region 128 数据接口 ISys_UserRoleDAL
		ISys_UserRoleDAL iSys_UserRoleDAL;
		public ISys_UserRoleDAL ISys_UserRoleDAL
		{
			get
			{
				if(iSys_UserRoleDAL==null)
					iSys_UserRoleDAL= new Sys_UserRoleDAL();
				return iSys_UserRoleDAL;
			}
			set
			{
				iSys_UserRoleDAL= value;
			}
		}
		#endregion

		#region 129 数据接口 ISys_UserSettingDAL
		ISys_UserSettingDAL iSys_UserSettingDAL;
		public ISys_UserSettingDAL ISys_UserSettingDAL
		{
			get
			{
				if(iSys_UserSettingDAL==null)
					iSys_UserSettingDAL= new Sys_UserSettingDAL();
				return iSys_UserSettingDAL;
			}
			set
			{
				iSys_UserSettingDAL= value;
			}
		}
		#endregion

		#region 130 数据接口 ISys_UserVipPermissionDAL
		ISys_UserVipPermissionDAL iSys_UserVipPermissionDAL;
		public ISys_UserVipPermissionDAL ISys_UserVipPermissionDAL
		{
			get
			{
				if(iSys_UserVipPermissionDAL==null)
					iSys_UserVipPermissionDAL= new Sys_UserVipPermissionDAL();
				return iSys_UserVipPermissionDAL;
			}
			set
			{
				iSys_UserVipPermissionDAL= value;
			}
		}
		#endregion

		#region 131 数据接口 IsysdiagramsDAL
		IsysdiagramsDAL isysdiagramsDAL;
		public IsysdiagramsDAL IsysdiagramsDAL
		{
			get
			{
				if(isysdiagramsDAL==null)
					isysdiagramsDAL= new sysdiagramsDAL();
				return isysdiagramsDAL;
			}
			set
			{
				isysdiagramsDAL= value;
			}
		}
		#endregion

		#region 132 数据接口 ITruck_AccountDAL
		ITruck_AccountDAL iTruck_AccountDAL;
		public ITruck_AccountDAL ITruck_AccountDAL
		{
			get
			{
				if(iTruck_AccountDAL==null)
					iTruck_AccountDAL= new Truck_AccountDAL();
				return iTruck_AccountDAL;
			}
			set
			{
				iTruck_AccountDAL= value;
			}
		}
		#endregion

		#region 133 数据接口 ITruck_Account2DAL
		ITruck_Account2DAL iTruck_Account2DAL;
		public ITruck_Account2DAL ITruck_Account2DAL
		{
			get
			{
				if(iTruck_Account2DAL==null)
					iTruck_Account2DAL= new Truck_Account2DAL();
				return iTruck_Account2DAL;
			}
			set
			{
				iTruck_Account2DAL= value;
			}
		}
		#endregion

		#region 134 数据接口 ITruck_Booking_ChargeDAL
		ITruck_Booking_ChargeDAL iTruck_Booking_ChargeDAL;
		public ITruck_Booking_ChargeDAL ITruck_Booking_ChargeDAL
		{
			get
			{
				if(iTruck_Booking_ChargeDAL==null)
					iTruck_Booking_ChargeDAL= new Truck_Booking_ChargeDAL();
				return iTruck_Booking_ChargeDAL;
			}
			set
			{
				iTruck_Booking_ChargeDAL= value;
			}
		}
		#endregion

		#region 135 数据接口 ITruck_Booking_ClientChargeDAL
		ITruck_Booking_ClientChargeDAL iTruck_Booking_ClientChargeDAL;
		public ITruck_Booking_ClientChargeDAL ITruck_Booking_ClientChargeDAL
		{
			get
			{
				if(iTruck_Booking_ClientChargeDAL==null)
					iTruck_Booking_ClientChargeDAL= new Truck_Booking_ClientChargeDAL();
				return iTruck_Booking_ClientChargeDAL;
			}
			set
			{
				iTruck_Booking_ClientChargeDAL= value;
			}
		}
		#endregion

		#region 136 数据接口 ITruck_Booking_DetailDAL
		ITruck_Booking_DetailDAL iTruck_Booking_DetailDAL;
		public ITruck_Booking_DetailDAL ITruck_Booking_DetailDAL
		{
			get
			{
				if(iTruck_Booking_DetailDAL==null)
					iTruck_Booking_DetailDAL= new Truck_Booking_DetailDAL();
				return iTruck_Booking_DetailDAL;
			}
			set
			{
				iTruck_Booking_DetailDAL= value;
			}
		}
		#endregion

		#region 137 数据接口 ITruck_Booking_FileDAL
		ITruck_Booking_FileDAL iTruck_Booking_FileDAL;
		public ITruck_Booking_FileDAL ITruck_Booking_FileDAL
		{
			get
			{
				if(iTruck_Booking_FileDAL==null)
					iTruck_Booking_FileDAL= new Truck_Booking_FileDAL();
				return iTruck_Booking_FileDAL;
			}
			set
			{
				iTruck_Booking_FileDAL= value;
			}
		}
		#endregion

		#region 138 数据接口 ITruck_Booking_HeadDAL
		ITruck_Booking_HeadDAL iTruck_Booking_HeadDAL;
		public ITruck_Booking_HeadDAL ITruck_Booking_HeadDAL
		{
			get
			{
				if(iTruck_Booking_HeadDAL==null)
					iTruck_Booking_HeadDAL= new Truck_Booking_HeadDAL();
				return iTruck_Booking_HeadDAL;
			}
			set
			{
				iTruck_Booking_HeadDAL= value;
			}
		}
		#endregion

		#region 139 数据接口 ITruck_Booking_RegDAL
		ITruck_Booking_RegDAL iTruck_Booking_RegDAL;
		public ITruck_Booking_RegDAL ITruck_Booking_RegDAL
		{
			get
			{
				if(iTruck_Booking_RegDAL==null)
					iTruck_Booking_RegDAL= new Truck_Booking_RegDAL();
				return iTruck_Booking_RegDAL;
			}
			set
			{
				iTruck_Booking_RegDAL= value;
			}
		}
		#endregion

		#region 140 数据接口 ITruck_CBM_WeightDAL
		ITruck_CBM_WeightDAL iTruck_CBM_WeightDAL;
		public ITruck_CBM_WeightDAL ITruck_CBM_WeightDAL
		{
			get
			{
				if(iTruck_CBM_WeightDAL==null)
					iTruck_CBM_WeightDAL= new Truck_CBM_WeightDAL();
				return iTruck_CBM_WeightDAL;
			}
			set
			{
				iTruck_CBM_WeightDAL= value;
			}
		}
		#endregion

		#region 141 数据接口 ITruck_ChargeNameDAL
		ITruck_ChargeNameDAL iTruck_ChargeNameDAL;
		public ITruck_ChargeNameDAL ITruck_ChargeNameDAL
		{
			get
			{
				if(iTruck_ChargeNameDAL==null)
					iTruck_ChargeNameDAL= new Truck_ChargeNameDAL();
				return iTruck_ChargeNameDAL;
			}
			set
			{
				iTruck_ChargeNameDAL= value;
			}
		}
		#endregion

		#region 142 数据接口 ITruck_ClientDAL
		ITruck_ClientDAL iTruck_ClientDAL;
		public ITruck_ClientDAL ITruck_ClientDAL
		{
			get
			{
				if(iTruck_ClientDAL==null)
					iTruck_ClientDAL= new Truck_ClientDAL();
				return iTruck_ClientDAL;
			}
			set
			{
				iTruck_ClientDAL= value;
			}
		}
		#endregion

		#region 143 数据接口 ITruck_CompanyDAL
		ITruck_CompanyDAL iTruck_CompanyDAL;
		public ITruck_CompanyDAL ITruck_CompanyDAL
		{
			get
			{
				if(iTruck_CompanyDAL==null)
					iTruck_CompanyDAL= new Truck_CompanyDAL();
				return iTruck_CompanyDAL;
			}
			set
			{
				iTruck_CompanyDAL= value;
			}
		}
		#endregion

		#region 144 数据接口 ITruck_Delivery_AddressDAL
		ITruck_Delivery_AddressDAL iTruck_Delivery_AddressDAL;
		public ITruck_Delivery_AddressDAL ITruck_Delivery_AddressDAL
		{
			get
			{
				if(iTruck_Delivery_AddressDAL==null)
					iTruck_Delivery_AddressDAL= new Truck_Delivery_AddressDAL();
				return iTruck_Delivery_AddressDAL;
			}
			set
			{
				iTruck_Delivery_AddressDAL= value;
			}
		}
		#endregion

		#region 145 数据接口 ITruck_DestDAL
		ITruck_DestDAL iTruck_DestDAL;
		public ITruck_DestDAL ITruck_DestDAL
		{
			get
			{
				if(iTruck_DestDAL==null)
					iTruck_DestDAL= new Truck_DestDAL();
				return iTruck_DestDAL;
			}
			set
			{
				iTruck_DestDAL= value;
			}
		}
		#endregion

		#region 146 数据接口 ITruck_Exchange_RateDAL
		ITruck_Exchange_RateDAL iTruck_Exchange_RateDAL;
		public ITruck_Exchange_RateDAL ITruck_Exchange_RateDAL
		{
			get
			{
				if(iTruck_Exchange_RateDAL==null)
					iTruck_Exchange_RateDAL= new Truck_Exchange_RateDAL();
				return iTruck_Exchange_RateDAL;
			}
			set
			{
				iTruck_Exchange_RateDAL= value;
			}
		}
		#endregion

		#region 147 数据接口 ITruck_InvoiceDAL
		ITruck_InvoiceDAL iTruck_InvoiceDAL;
		public ITruck_InvoiceDAL ITruck_InvoiceDAL
		{
			get
			{
				if(iTruck_InvoiceDAL==null)
					iTruck_InvoiceDAL= new Truck_InvoiceDAL();
				return iTruck_InvoiceDAL;
			}
			set
			{
				iTruck_InvoiceDAL= value;
			}
		}
		#endregion

		#region 148 数据接口 ITruck_Invoice_CodeDAL
		ITruck_Invoice_CodeDAL iTruck_Invoice_CodeDAL;
		public ITruck_Invoice_CodeDAL ITruck_Invoice_CodeDAL
		{
			get
			{
				if(iTruck_Invoice_CodeDAL==null)
					iTruck_Invoice_CodeDAL= new Truck_Invoice_CodeDAL();
				return iTruck_Invoice_CodeDAL;
			}
			set
			{
				iTruck_Invoice_CodeDAL= value;
			}
		}
		#endregion

		#region 149 数据接口 ITruck_Invoice_InfoDAL
		ITruck_Invoice_InfoDAL iTruck_Invoice_InfoDAL;
		public ITruck_Invoice_InfoDAL ITruck_Invoice_InfoDAL
		{
			get
			{
				if(iTruck_Invoice_InfoDAL==null)
					iTruck_Invoice_InfoDAL= new Truck_Invoice_InfoDAL();
				return iTruck_Invoice_InfoDAL;
			}
			set
			{
				iTruck_Invoice_InfoDAL= value;
			}
		}
		#endregion

		#region 150 数据接口 ITruck_Invoice_Info_AddDAL
		ITruck_Invoice_Info_AddDAL iTruck_Invoice_Info_AddDAL;
		public ITruck_Invoice_Info_AddDAL ITruck_Invoice_Info_AddDAL
		{
			get
			{
				if(iTruck_Invoice_Info_AddDAL==null)
					iTruck_Invoice_Info_AddDAL= new Truck_Invoice_Info_AddDAL();
				return iTruck_Invoice_Info_AddDAL;
			}
			set
			{
				iTruck_Invoice_Info_AddDAL= value;
			}
		}
		#endregion

		#region 151 数据接口 ITruck_Loading_AddressDAL
		ITruck_Loading_AddressDAL iTruck_Loading_AddressDAL;
		public ITruck_Loading_AddressDAL ITruck_Loading_AddressDAL
		{
			get
			{
				if(iTruck_Loading_AddressDAL==null)
					iTruck_Loading_AddressDAL= new Truck_Loading_AddressDAL();
				return iTruck_Loading_AddressDAL;
			}
			set
			{
				iTruck_Loading_AddressDAL= value;
			}
		}
		#endregion

		#region 152 数据接口 ITruck_PackingListDAL
		ITruck_PackingListDAL iTruck_PackingListDAL;
		public ITruck_PackingListDAL ITruck_PackingListDAL
		{
			get
			{
				if(iTruck_PackingListDAL==null)
					iTruck_PackingListDAL= new Truck_PackingListDAL();
				return iTruck_PackingListDAL;
			}
			set
			{
				iTruck_PackingListDAL= value;
			}
		}
		#endregion

		#region 153 数据接口 ITruck_PODAL
		ITruck_PODAL iTruck_PODAL;
		public ITruck_PODAL ITruck_PODAL
		{
			get
			{
				if(iTruck_PODAL==null)
					iTruck_PODAL= new Truck_PODAL();
				return iTruck_PODAL;
			}
			set
			{
				iTruck_PODAL= value;
			}
		}
		#endregion

		#region 154 数据接口 ITruck_Storage_YardDAL
		ITruck_Storage_YardDAL iTruck_Storage_YardDAL;
		public ITruck_Storage_YardDAL ITruck_Storage_YardDAL
		{
			get
			{
				if(iTruck_Storage_YardDAL==null)
					iTruck_Storage_YardDAL= new Truck_Storage_YardDAL();
				return iTruck_Storage_YardDAL;
			}
			set
			{
				iTruck_Storage_YardDAL= value;
			}
		}
		#endregion

		#region 155 数据接口 ITruck_VendorDAL
		ITruck_VendorDAL iTruck_VendorDAL;
		public ITruck_VendorDAL ITruck_VendorDAL
		{
			get
			{
				if(iTruck_VendorDAL==null)
					iTruck_VendorDAL= new Truck_VendorDAL();
				return iTruck_VendorDAL;
			}
			set
			{
				iTruck_VendorDAL= value;
			}
		}
		#endregion

		#region 156 数据接口 ITruck_Vendor_ClientDAL
		ITruck_Vendor_ClientDAL iTruck_Vendor_ClientDAL;
		public ITruck_Vendor_ClientDAL ITruck_Vendor_ClientDAL
		{
			get
			{
				if(iTruck_Vendor_ClientDAL==null)
					iTruck_Vendor_ClientDAL= new Truck_Vendor_ClientDAL();
				return iTruck_Vendor_ClientDAL;
			}
			set
			{
				iTruck_Vendor_ClientDAL= value;
			}
		}
		#endregion

		#region 157 数据接口 ITruck_WarehouseDAL
		ITruck_WarehouseDAL iTruck_WarehouseDAL;
		public ITruck_WarehouseDAL ITruck_WarehouseDAL
		{
			get
			{
				if(iTruck_WarehouseDAL==null)
					iTruck_WarehouseDAL= new Truck_WarehouseDAL();
				return iTruck_WarehouseDAL;
			}
			set
			{
				iTruck_WarehouseDAL= value;
			}
		}
		#endregion

		#region 158 数据接口 ITruckUnLoadTimeDAL
		ITruckUnLoadTimeDAL iTruckUnLoadTimeDAL;
		public ITruckUnLoadTimeDAL ITruckUnLoadTimeDAL
		{
			get
			{
				if(iTruckUnLoadTimeDAL==null)
					iTruckUnLoadTimeDAL= new TruckUnLoadTimeDAL();
				return iTruckUnLoadTimeDAL;
			}
			set
			{
				iTruckUnLoadTimeDAL= value;
			}
		}
		#endregion

		#region 159 数据接口 IturnoverDAL
		IturnoverDAL iturnoverDAL;
		public IturnoverDAL IturnoverDAL
		{
			get
			{
				if(iturnoverDAL==null)
					iturnoverDAL= new turnoverDAL();
				return iturnoverDAL;
			}
			set
			{
				iturnoverDAL= value;
			}
		}
		#endregion

		#region 160 数据接口 IunitDAL
		IunitDAL iunitDAL;
		public IunitDAL IunitDAL
		{
			get
			{
				if(iunitDAL==null)
					iunitDAL= new unitDAL();
				return iunitDAL;
			}
			set
			{
				iunitDAL= value;
			}
		}
		#endregion

		#region 161 数据接口 IUnloadingDAL
		IUnloadingDAL iUnloadingDAL;
		public IUnloadingDAL IUnloadingDAL
		{
			get
			{
				if(iUnloadingDAL==null)
					iUnloadingDAL= new UnloadingDAL();
				return iUnloadingDAL;
			}
			set
			{
				iUnloadingDAL= value;
			}
		}
		#endregion

		#region 162 数据接口 IUser_PasswordDAL
		IUser_PasswordDAL iUser_PasswordDAL;
		public IUser_PasswordDAL IUser_PasswordDAL
		{
			get
			{
				if(iUser_PasswordDAL==null)
					iUser_PasswordDAL= new User_PasswordDAL();
				return iUser_PasswordDAL;
			}
			set
			{
				iUser_PasswordDAL= value;
			}
		}
		#endregion

		#region 163 数据接口 IuserlogDAL
		IuserlogDAL iuserlogDAL;
		public IuserlogDAL IuserlogDAL
		{
			get
			{
				if(iuserlogDAL==null)
					iuserlogDAL= new userlogDAL();
				return iuserlogDAL;
			}
			set
			{
				iuserlogDAL= value;
			}
		}
		#endregion

		#region 164 数据接口 IVehicleDAL
		IVehicleDAL iVehicleDAL;
		public IVehicleDAL IVehicleDAL
		{
			get
			{
				if(iVehicleDAL==null)
					iVehicleDAL= new VehicleDAL();
				return iVehicleDAL;
			}
			set
			{
				iVehicleDAL= value;
			}
		}
		#endregion

		#region 165 数据接口 IvendorDAL
		IvendorDAL ivendorDAL;
		public IvendorDAL IvendorDAL
		{
			get
			{
				if(ivendorDAL==null)
					ivendorDAL= new vendorDAL();
				return ivendorDAL;
			}
			set
			{
				ivendorDAL= value;
			}
		}
		#endregion

		#region 166 数据接口 IVendorInfoDAL
		IVendorInfoDAL iVendorInfoDAL;
		public IVendorInfoDAL IVendorInfoDAL
		{
			get
			{
				if(iVendorInfoDAL==null)
					iVendorInfoDAL= new VendorInfoDAL();
				return iVendorInfoDAL;
			}
			set
			{
				iVendorInfoDAL= value;
			}
		}
		#endregion

		#region 167 数据接口 IvesselDAL
		IvesselDAL ivesselDAL;
		public IvesselDAL IvesselDAL
		{
			get
			{
				if(ivesselDAL==null)
					ivesselDAL= new vesselDAL();
				return ivesselDAL;
			}
			set
			{
				ivesselDAL= value;
			}
		}
		#endregion

		#region 168 数据接口 IwhsDAL
		IwhsDAL iwhsDAL;
		public IwhsDAL IwhsDAL
		{
			get
			{
				if(iwhsDAL==null)
					iwhsDAL= new whsDAL();
				return iwhsDAL;
			}
			set
			{
				iwhsDAL= value;
			}
		}
		#endregion

		#region 169 数据接口 IypmfuserDAL
		IypmfuserDAL iypmfuserDAL;
		public IypmfuserDAL IypmfuserDAL
		{
			get
			{
				if(iypmfuserDAL==null)
					iypmfuserDAL= new ypmfuserDAL();
				return iypmfuserDAL;
			}
			set
			{
				iypmfuserDAL= value;
			}
		}
		#endregion

    }

}