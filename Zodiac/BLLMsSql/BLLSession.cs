﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBLL;

namespace BLLMsSql
{
	public partial class BLLSession:IBLLSession
    {
		#region 01 业务接口 IaccountDAL
		IaccountBLL iaccountBLL;
		public IaccountBLL IaccountBLL
		{
			get
			{
				if(iaccountBLL==null)
					iaccountBLL= new accountService();
				return iaccountBLL;
			}
			set
			{
				iaccountBLL= value;
			}
		}
		#endregion

		#region 02 业务接口 IAccountContInfoDAL
		IAccountContInfoBLL iAccountContInfoBLL;
		public IAccountContInfoBLL IAccountContInfoBLL
		{
			get
			{
				if(iAccountContInfoBLL==null)
					iAccountContInfoBLL= new AccountContInfoService();
				return iAccountContInfoBLL;
			}
			set
			{
				iAccountContInfoBLL= value;
			}
		}
		#endregion

		#region 03 业务接口 IAdditionalOutDAL
		IAdditionalOutBLL iAdditionalOutBLL;
		public IAdditionalOutBLL IAdditionalOutBLL
		{
			get
			{
				if(iAdditionalOutBLL==null)
					iAdditionalOutBLL= new AdditionalOutService();
				return iAdditionalOutBLL;
			}
			set
			{
				iAdditionalOutBLL= value;
			}
		}
		#endregion

		#region 04 业务接口 IBasic_Return_AddressDAL
		IBasic_Return_AddressBLL iBasic_Return_AddressBLL;
		public IBasic_Return_AddressBLL IBasic_Return_AddressBLL
		{
			get
			{
				if(iBasic_Return_AddressBLL==null)
					iBasic_Return_AddressBLL= new Basic_Return_AddressService();
				return iBasic_Return_AddressBLL;
			}
			set
			{
				iBasic_Return_AddressBLL= value;
			}
		}
		#endregion

		#region 05 业务接口 IBn_ZodiacDAL
		IBn_ZodiacBLL iBn_ZodiacBLL;
		public IBn_ZodiacBLL IBn_ZodiacBLL
		{
			get
			{
				if(iBn_ZodiacBLL==null)
					iBn_ZodiacBLL= new Bn_ZodiacService();
				return iBn_ZodiacBLL;
			}
			set
			{
				iBn_ZodiacBLL= value;
			}
		}
		#endregion

		#region 06 业务接口 IBookingDetailEdiDAL
		IBookingDetailEdiBLL iBookingDetailEdiBLL;
		public IBookingDetailEdiBLL IBookingDetailEdiBLL
		{
			get
			{
				if(iBookingDetailEdiBLL==null)
					iBookingDetailEdiBLL= new BookingDetailEdiService();
				return iBookingDetailEdiBLL;
			}
			set
			{
				iBookingDetailEdiBLL= value;
			}
		}
		#endregion

		#region 07 业务接口 IbookingDtlDAL
		IbookingDtlBLL ibookingDtlBLL;
		public IbookingDtlBLL IbookingDtlBLL
		{
			get
			{
				if(ibookingDtlBLL==null)
					ibookingDtlBLL= new bookingDtlService();
				return ibookingDtlBLL;
			}
			set
			{
				ibookingDtlBLL= value;
			}
		}
		#endregion

		#region 08 业务接口 IbookingForwardDAL
		IbookingForwardBLL ibookingForwardBLL;
		public IbookingForwardBLL IbookingForwardBLL
		{
			get
			{
				if(ibookingForwardBLL==null)
					ibookingForwardBLL= new bookingForwardService();
				return ibookingForwardBLL;
			}
			set
			{
				ibookingForwardBLL= value;
			}
		}
		#endregion

		#region 09 业务接口 IbookingHeadDAL
		IbookingHeadBLL ibookingHeadBLL;
		public IbookingHeadBLL IbookingHeadBLL
		{
			get
			{
				if(ibookingHeadBLL==null)
					ibookingHeadBLL= new bookingHeadService();
				return ibookingHeadBLL;
			}
			set
			{
				ibookingHeadBLL= value;
			}
		}
		#endregion

		#region 10 业务接口 IBookingHeadEdiDAL
		IBookingHeadEdiBLL iBookingHeadEdiBLL;
		public IBookingHeadEdiBLL IBookingHeadEdiBLL
		{
			get
			{
				if(iBookingHeadEdiBLL==null)
					iBookingHeadEdiBLL= new BookingHeadEdiService();
				return iBookingHeadEdiBLL;
			}
			set
			{
				iBookingHeadEdiBLL= value;
			}
		}
		#endregion

		#region 11 业务接口 IbookingUserDAL
		IbookingUserBLL ibookingUserBLL;
		public IbookingUserBLL IbookingUserBLL
		{
			get
			{
				if(ibookingUserBLL==null)
					ibookingUserBLL= new bookingUserService();
				return ibookingUserBLL;
			}
			set
			{
				ibookingUserBLL= value;
			}
		}
		#endregion

		#region 12 业务接口 IbookingVendorDAL
		IbookingVendorBLL ibookingVendorBLL;
		public IbookingVendorBLL IbookingVendorBLL
		{
			get
			{
				if(ibookingVendorBLL==null)
					ibookingVendorBLL= new bookingVendorService();
				return ibookingVendorBLL;
			}
			set
			{
				ibookingVendorBLL= value;
			}
		}
		#endregion

		#region 13 业务接口 Icarrier_bookingDAL
		Icarrier_bookingBLL icarrier_bookingBLL;
		public Icarrier_bookingBLL Icarrier_bookingBLL
		{
			get
			{
				if(icarrier_bookingBLL==null)
					icarrier_bookingBLL= new carrier_bookingService();
				return icarrier_bookingBLL;
			}
			set
			{
				icarrier_bookingBLL= value;
			}
		}
		#endregion

		#region 14 业务接口 ICarrierInfoDAL
		ICarrierInfoBLL iCarrierInfoBLL;
		public ICarrierInfoBLL ICarrierInfoBLL
		{
			get
			{
				if(iCarrierInfoBLL==null)
					iCarrierInfoBLL= new CarrierInfoService();
				return iCarrierInfoBLL;
			}
			set
			{
				iCarrierInfoBLL= value;
			}
		}
		#endregion

		#region 15 业务接口 IcategoryDAL
		IcategoryBLL icategoryBLL;
		public IcategoryBLL IcategoryBLL
		{
			get
			{
				if(icategoryBLL==null)
					icategoryBLL= new categoryService();
				return icategoryBLL;
			}
			set
			{
				icategoryBLL= value;
			}
		}
		#endregion

		#region 16 业务接口 IChargeDEBITNOTEDAL
		IChargeDEBITNOTEBLL iChargeDEBITNOTEBLL;
		public IChargeDEBITNOTEBLL IChargeDEBITNOTEBLL
		{
			get
			{
				if(iChargeDEBITNOTEBLL==null)
					iChargeDEBITNOTEBLL= new ChargeDEBITNOTEService();
				return iChargeDEBITNOTEBLL;
			}
			set
			{
				iChargeDEBITNOTEBLL= value;
			}
		}
		#endregion

		#region 17 业务接口 IChargeNameDAL
		IChargeNameBLL iChargeNameBLL;
		public IChargeNameBLL IChargeNameBLL
		{
			get
			{
				if(iChargeNameBLL==null)
					iChargeNameBLL= new ChargeNameService();
				return iChargeNameBLL;
			}
			set
			{
				iChargeNameBLL= value;
			}
		}
		#endregion

		#region 18 业务接口 IClientDAL
		IClientBLL iClientBLL;
		public IClientBLL IClientBLL
		{
			get
			{
				if(iClientBLL==null)
					iClientBLL= new ClientService();
				return iClientBLL;
			}
			set
			{
				iClientBLL= value;
			}
		}
		#endregion

		#region 19 业务接口 Iclp_chargeListDAL
		Iclp_chargeListBLL iclp_chargeListBLL;
		public Iclp_chargeListBLL Iclp_chargeListBLL
		{
			get
			{
				if(iclp_chargeListBLL==null)
					iclp_chargeListBLL= new clp_chargeListService();
				return iclp_chargeListBLL;
			}
			set
			{
				iclp_chargeListBLL= value;
			}
		}
		#endregion

		#region 20 业务接口 IcollectlistDAL
		IcollectlistBLL icollectlistBLL;
		public IcollectlistBLL IcollectlistBLL
		{
			get
			{
				if(icollectlistBLL==null)
					icollectlistBLL= new collectlistService();
				return icollectlistBLL;
			}
			set
			{
				icollectlistBLL= value;
			}
		}
		#endregion

		#region 21 业务接口 Icon_sizeDAL
		Icon_sizeBLL icon_sizeBLL;
		public Icon_sizeBLL Icon_sizeBLL
		{
			get
			{
				if(icon_sizeBLL==null)
					icon_sizeBLL= new con_sizeService();
				return icon_sizeBLL;
			}
			set
			{
				icon_sizeBLL= value;
			}
		}
		#endregion

		#region 22 业务接口 IconsigneeDAL
		IconsigneeBLL iconsigneeBLL;
		public IconsigneeBLL IconsigneeBLL
		{
			get
			{
				if(iconsigneeBLL==null)
					iconsigneeBLL= new consigneeService();
				return iconsigneeBLL;
			}
			set
			{
				iconsigneeBLL= value;
			}
		}
		#endregion

		#region 23 业务接口 Icont_addressDAL
		Icont_addressBLL icont_addressBLL;
		public Icont_addressBLL Icont_addressBLL
		{
			get
			{
				if(icont_addressBLL==null)
					icont_addressBLL= new cont_addressService();
				return icont_addressBLL;
			}
			set
			{
				icont_addressBLL= value;
			}
		}
		#endregion

		#region 24 业务接口 ICont_SizeDAL
		ICont_SizeBLL iCont_SizeBLL;
		public ICont_SizeBLL ICont_SizeBLL
		{
			get
			{
				if(iCont_SizeBLL==null)
					iCont_SizeBLL= new Cont_SizeService();
				return iCont_SizeBLL;
			}
			set
			{
				iCont_SizeBLL= value;
			}
		}
		#endregion

		#region 25 业务接口 IContTransFeeDAL
		IContTransFeeBLL iContTransFeeBLL;
		public IContTransFeeBLL IContTransFeeBLL
		{
			get
			{
				if(iContTransFeeBLL==null)
					iContTransFeeBLL= new ContTransFeeService();
				return iContTransFeeBLL;
			}
			set
			{
				iContTransFeeBLL= value;
			}
		}
		#endregion

		#region 26 业务接口 ICurr_RateDAL
		ICurr_RateBLL iCurr_RateBLL;
		public ICurr_RateBLL ICurr_RateBLL
		{
			get
			{
				if(iCurr_RateBLL==null)
					iCurr_RateBLL= new Curr_RateService();
				return iCurr_RateBLL;
			}
			set
			{
				iCurr_RateBLL= value;
			}
		}
		#endregion

		#region 27 业务接口 Icus_contDAL
		Icus_contBLL icus_contBLL;
		public Icus_contBLL Icus_contBLL
		{
			get
			{
				if(icus_contBLL==null)
					icus_contBLL= new cus_contService();
				return icus_contBLL;
			}
			set
			{
				icus_contBLL= value;
			}
		}
		#endregion

		#region 28 业务接口 Icus_hchgDAL
		Icus_hchgBLL icus_hchgBLL;
		public Icus_hchgBLL Icus_hchgBLL
		{
			get
			{
				if(icus_hchgBLL==null)
					icus_hchgBLL= new cus_hchgService();
				return icus_hchgBLL;
			}
			set
			{
				icus_hchgBLL= value;
			}
		}
		#endregion

		#region 29 业务接口 IcustinDAL
		IcustinBLL icustinBLL;
		public IcustinBLL IcustinBLL
		{
			get
			{
				if(icustinBLL==null)
					icustinBLL= new custinService();
				return icustinBLL;
			}
			set
			{
				icustinBLL= value;
			}
		}
		#endregion

		#region 30 业务接口 IcustinnoDAL
		IcustinnoBLL icustinnoBLL;
		public IcustinnoBLL IcustinnoBLL
		{
			get
			{
				if(icustinnoBLL==null)
					icustinnoBLL= new custinnoService();
				return icustinnoBLL;
			}
			set
			{
				icustinnoBLL= value;
			}
		}
		#endregion

		#region 31 业务接口 IcustomerDAL
		IcustomerBLL icustomerBLL;
		public IcustomerBLL IcustomerBLL
		{
			get
			{
				if(icustomerBLL==null)
					icustomerBLL= new customerService();
				return icustomerBLL;
			}
			set
			{
				icustomerBLL= value;
			}
		}
		#endregion

		#region 32 业务接口 ICustomer_OrderDAL
		ICustomer_OrderBLL iCustomer_OrderBLL;
		public ICustomer_OrderBLL ICustomer_OrderBLL
		{
			get
			{
				if(iCustomer_OrderBLL==null)
					iCustomer_OrderBLL= new Customer_OrderService();
				return iCustomer_OrderBLL;
			}
			set
			{
				iCustomer_OrderBLL= value;
			}
		}
		#endregion

		#region 33 业务接口 ICustomer_Order_PlanDAL
		ICustomer_Order_PlanBLL iCustomer_Order_PlanBLL;
		public ICustomer_Order_PlanBLL ICustomer_Order_PlanBLL
		{
			get
			{
				if(iCustomer_Order_PlanBLL==null)
					iCustomer_Order_PlanBLL= new Customer_Order_PlanService();
				return iCustomer_Order_PlanBLL;
			}
			set
			{
				iCustomer_Order_PlanBLL= value;
			}
		}
		#endregion

		#region 34 业务接口 Icustomer1DAL
		Icustomer1BLL icustomer1BLL;
		public Icustomer1BLL Icustomer1BLL
		{
			get
			{
				if(icustomer1BLL==null)
					icustomer1BLL= new customer1Service();
				return icustomer1BLL;
			}
			set
			{
				icustomer1BLL= value;
			}
		}
		#endregion

		#region 35 业务接口 IcustomsDAL
		IcustomsBLL icustomsBLL;
		public IcustomsBLL IcustomsBLL
		{
			get
			{
				if(icustomsBLL==null)
					icustomsBLL= new customsService();
				return icustomsBLL;
			}
			set
			{
				icustomsBLL= value;
			}
		}
		#endregion

		#region 36 业务接口 Icustoms_headDAL
		Icustoms_headBLL icustoms_headBLL;
		public Icustoms_headBLL Icustoms_headBLL
		{
			get
			{
				if(icustoms_headBLL==null)
					icustoms_headBLL= new customs_headService();
				return icustoms_headBLL;
			}
			set
			{
				icustoms_headBLL= value;
			}
		}
		#endregion

		#region 37 业务接口 Icustoms_itemDAL
		Icustoms_itemBLL icustoms_itemBLL;
		public Icustoms_itemBLL Icustoms_itemBLL
		{
			get
			{
				if(icustoms_itemBLL==null)
					icustoms_itemBLL= new customs_itemService();
				return icustoms_itemBLL;
			}
			set
			{
				icustoms_itemBLL= value;
			}
		}
		#endregion

		#region 38 业务接口 Icustoms_outDAL
		Icustoms_outBLL icustoms_outBLL;
		public Icustoms_outBLL Icustoms_outBLL
		{
			get
			{
				if(icustoms_outBLL==null)
					icustoms_outBLL= new customs_outService();
				return icustoms_outBLL;
			}
			set
			{
				icustoms_outBLL= value;
			}
		}
		#endregion

		#region 39 业务接口 ICustomsTypeDAL
		ICustomsTypeBLL iCustomsTypeBLL;
		public ICustomsTypeBLL ICustomsTypeBLL
		{
			get
			{
				if(iCustomsTypeBLL==null)
					iCustomsTypeBLL= new CustomsTypeService();
				return iCustomsTypeBLL;
			}
			set
			{
				iCustomsTypeBLL= value;
			}
		}
		#endregion

		#region 40 业务接口 IcustoutnoDAL
		IcustoutnoBLL icustoutnoBLL;
		public IcustoutnoBLL IcustoutnoBLL
		{
			get
			{
				if(icustoutnoBLL==null)
					icustoutnoBLL= new custoutnoService();
				return icustoutnoBLL;
			}
			set
			{
				icustoutnoBLL= value;
			}
		}
		#endregion

		#region 41 业务接口 IDailyCustomsDocuDAL
		IDailyCustomsDocuBLL iDailyCustomsDocuBLL;
		public IDailyCustomsDocuBLL IDailyCustomsDocuBLL
		{
			get
			{
				if(iDailyCustomsDocuBLL==null)
					iDailyCustomsDocuBLL= new DailyCustomsDocuService();
				return iDailyCustomsDocuBLL;
			}
			set
			{
				iDailyCustomsDocuBLL= value;
			}
		}
		#endregion

		#region 42 业务接口 IDailyDataforCustomsDAL
		IDailyDataforCustomsBLL iDailyDataforCustomsBLL;
		public IDailyDataforCustomsBLL IDailyDataforCustomsBLL
		{
			get
			{
				if(iDailyDataforCustomsBLL==null)
					iDailyDataforCustomsBLL= new DailyDataforCustomsService();
				return iDailyDataforCustomsBLL;
			}
			set
			{
				iDailyDataforCustomsBLL= value;
			}
		}
		#endregion

		#region 43 业务接口 IDailyTurnoverDAL
		IDailyTurnoverBLL iDailyTurnoverBLL;
		public IDailyTurnoverBLL IDailyTurnoverBLL
		{
			get
			{
				if(iDailyTurnoverBLL==null)
					iDailyTurnoverBLL= new DailyTurnoverService();
				return iDailyTurnoverBLL;
			}
			set
			{
				iDailyTurnoverBLL= value;
			}
		}
		#endregion

		#region 44 业务接口 IDebitNoteNoDAL
		IDebitNoteNoBLL iDebitNoteNoBLL;
		public IDebitNoteNoBLL IDebitNoteNoBLL
		{
			get
			{
				if(iDebitNoteNoBLL==null)
					iDebitNoteNoBLL= new DebitNoteNoService();
				return iDebitNoteNoBLL;
			}
			set
			{
				iDebitNoteNoBLL= value;
			}
		}
		#endregion

		#region 45 业务接口 Idecl_noDAL
		Idecl_noBLL idecl_noBLL;
		public Idecl_noBLL Idecl_noBLL
		{
			get
			{
				if(idecl_noBLL==null)
					idecl_noBLL= new decl_noService();
				return idecl_noBLL;
			}
			set
			{
				idecl_noBLL= value;
			}
		}
		#endregion

		#region 46 业务接口 IdestDAL
		IdestBLL idestBLL;
		public IdestBLL IdestBLL
		{
			get
			{
				if(idestBLL==null)
					idestBLL= new destService();
				return idestBLL;
			}
			set
			{
				idestBLL= value;
			}
		}
		#endregion

		#region 47 业务接口 IdestinationDAL
		IdestinationBLL idestinationBLL;
		public IdestinationBLL IdestinationBLL
		{
			get
			{
				if(idestinationBLL==null)
					idestinationBLL= new destinationService();
				return idestinationBLL;
			}
			set
			{
				idestinationBLL= value;
			}
		}
		#endregion

		#region 48 业务接口 IDestInfo2DAL
		IDestInfo2BLL iDestInfo2BLL;
		public IDestInfo2BLL IDestInfo2BLL
		{
			get
			{
				if(iDestInfo2BLL==null)
					iDestInfo2BLL= new DestInfo2Service();
				return iDestInfo2BLL;
			}
			set
			{
				iDestInfo2BLL= value;
			}
		}
		#endregion

		#region 49 业务接口 IDestOfBRSIDAL
		IDestOfBRSIBLL iDestOfBRSIBLL;
		public IDestOfBRSIBLL IDestOfBRSIBLL
		{
			get
			{
				if(iDestOfBRSIBLL==null)
					iDestOfBRSIBLL= new DestOfBRSIService();
				return iDestOfBRSIBLL;
			}
			set
			{
				iDestOfBRSIBLL= value;
			}
		}
		#endregion

		#region 50 业务接口 IdobitNoteLogDAL
		IdobitNoteLogBLL idobitNoteLogBLL;
		public IdobitNoteLogBLL IdobitNoteLogBLL
		{
			get
			{
				if(idobitNoteLogBLL==null)
					idobitNoteLogBLL= new dobitNoteLogService();
				return idobitNoteLogBLL;
			}
			set
			{
				idobitNoteLogBLL= value;
			}
		}
		#endregion

		#region 51 业务接口 IdtpropertiesDAL
		IdtpropertiesBLL idtpropertiesBLL;
		public IdtpropertiesBLL IdtpropertiesBLL
		{
			get
			{
				if(idtpropertiesBLL==null)
					idtpropertiesBLL= new dtpropertiesService();
				return idtpropertiesBLL;
			}
			set
			{
				idtpropertiesBLL= value;
			}
		}
		#endregion

		#region 52 业务接口 IEDIExcptnRegDAL
		IEDIExcptnRegBLL iEDIExcptnRegBLL;
		public IEDIExcptnRegBLL IEDIExcptnRegBLL
		{
			get
			{
				if(iEDIExcptnRegBLL==null)
					iEDIExcptnRegBLL= new EDIExcptnRegService();
				return iEDIExcptnRegBLL;
			}
			set
			{
				iEDIExcptnRegBLL= value;
			}
		}
		#endregion

		#region 53 业务接口 IEmployeesDAL
		IEmployeesBLL iEmployeesBLL;
		public IEmployeesBLL IEmployeesBLL
		{
			get
			{
				if(iEmployeesBLL==null)
					iEmployeesBLL= new EmployeesService();
				return iEmployeesBLL;
			}
			set
			{
				iEmployeesBLL= value;
			}
		}
		#endregion

		#region 54 业务接口 IExchange_RateDAL
		IExchange_RateBLL iExchange_RateBLL;
		public IExchange_RateBLL IExchange_RateBLL
		{
			get
			{
				if(iExchange_RateBLL==null)
					iExchange_RateBLL= new Exchange_RateService();
				return iExchange_RateBLL;
			}
			set
			{
				iExchange_RateBLL= value;
			}
		}
		#endregion

		#region 55 业务接口 IExclusionCustomsDAL
		IExclusionCustomsBLL iExclusionCustomsBLL;
		public IExclusionCustomsBLL IExclusionCustomsBLL
		{
			get
			{
				if(iExclusionCustomsBLL==null)
					iExclusionCustomsBLL= new ExclusionCustomsService();
				return iExclusionCustomsBLL;
			}
			set
			{
				iExclusionCustomsBLL= value;
			}
		}
		#endregion

		#region 56 业务接口 IFCR_DetailDAL
		IFCR_DetailBLL iFCR_DetailBLL;
		public IFCR_DetailBLL IFCR_DetailBLL
		{
			get
			{
				if(iFCR_DetailBLL==null)
					iFCR_DetailBLL= new FCR_DetailService();
				return iFCR_DetailBLL;
			}
			set
			{
				iFCR_DetailBLL= value;
			}
		}
		#endregion

		#region 57 业务接口 IFCR_Discharging_PortDAL
		IFCR_Discharging_PortBLL iFCR_Discharging_PortBLL;
		public IFCR_Discharging_PortBLL IFCR_Discharging_PortBLL
		{
			get
			{
				if(iFCR_Discharging_PortBLL==null)
					iFCR_Discharging_PortBLL= new FCR_Discharging_PortService();
				return iFCR_Discharging_PortBLL;
			}
			set
			{
				iFCR_Discharging_PortBLL= value;
			}
		}
		#endregion

		#region 58 业务接口 IFCR_FactoryDAL
		IFCR_FactoryBLL iFCR_FactoryBLL;
		public IFCR_FactoryBLL IFCR_FactoryBLL
		{
			get
			{
				if(iFCR_FactoryBLL==null)
					iFCR_FactoryBLL= new FCR_FactoryService();
				return iFCR_FactoryBLL;
			}
			set
			{
				iFCR_FactoryBLL= value;
			}
		}
		#endregion

		#region 59 业务接口 IFCR_HeadDAL
		IFCR_HeadBLL iFCR_HeadBLL;
		public IFCR_HeadBLL IFCR_HeadBLL
		{
			get
			{
				if(iFCR_HeadBLL==null)
					iFCR_HeadBLL= new FCR_HeadService();
				return iFCR_HeadBLL;
			}
			set
			{
				iFCR_HeadBLL= value;
			}
		}
		#endregion

		#region 60 业务接口 IFCR_SupplierDAL
		IFCR_SupplierBLL iFCR_SupplierBLL;
		public IFCR_SupplierBLL IFCR_SupplierBLL
		{
			get
			{
				if(iFCR_SupplierBLL==null)
					iFCR_SupplierBLL= new FCR_SupplierService();
				return iFCR_SupplierBLL;
			}
			set
			{
				iFCR_SupplierBLL= value;
			}
		}
		#endregion

		#region 61 业务接口 IFcrSMBaseChargeDAL
		IFcrSMBaseChargeBLL iFcrSMBaseChargeBLL;
		public IFcrSMBaseChargeBLL IFcrSMBaseChargeBLL
		{
			get
			{
				if(iFcrSMBaseChargeBLL==null)
					iFcrSMBaseChargeBLL= new FcrSMBaseChargeService();
				return iFcrSMBaseChargeBLL;
			}
			set
			{
				iFcrSMBaseChargeBLL= value;
			}
		}
		#endregion

		#region 62 业务接口 IFinalLoadingPlanDAL
		IFinalLoadingPlanBLL iFinalLoadingPlanBLL;
		public IFinalLoadingPlanBLL IFinalLoadingPlanBLL
		{
			get
			{
				if(iFinalLoadingPlanBLL==null)
					iFinalLoadingPlanBLL= new FinalLoadingPlanService();
				return iFinalLoadingPlanBLL;
			}
			set
			{
				iFinalLoadingPlanBLL= value;
			}
		}
		#endregion

		#region 63 业务接口 IFinalLoadingPlan_PaymentDAL
		IFinalLoadingPlan_PaymentBLL iFinalLoadingPlan_PaymentBLL;
		public IFinalLoadingPlan_PaymentBLL IFinalLoadingPlan_PaymentBLL
		{
			get
			{
				if(iFinalLoadingPlan_PaymentBLL==null)
					iFinalLoadingPlan_PaymentBLL= new FinalLoadingPlan_PaymentService();
				return iFinalLoadingPlan_PaymentBLL;
			}
			set
			{
				iFinalLoadingPlan_PaymentBLL= value;
			}
		}
		#endregion

		#region 64 业务接口 IFinalLoadPlanAmazonVendorDAL
		IFinalLoadPlanAmazonVendorBLL iFinalLoadPlanAmazonVendorBLL;
		public IFinalLoadPlanAmazonVendorBLL IFinalLoadPlanAmazonVendorBLL
		{
			get
			{
				if(iFinalLoadPlanAmazonVendorBLL==null)
					iFinalLoadPlanAmazonVendorBLL= new FinalLoadPlanAmazonVendorService();
				return iFinalLoadPlanAmazonVendorBLL;
			}
			set
			{
				iFinalLoadPlanAmazonVendorBLL= value;
			}
		}
		#endregion

		#region 65 业务接口 IFinalLoadPlanHolidayDAL
		IFinalLoadPlanHolidayBLL iFinalLoadPlanHolidayBLL;
		public IFinalLoadPlanHolidayBLL IFinalLoadPlanHolidayBLL
		{
			get
			{
				if(iFinalLoadPlanHolidayBLL==null)
					iFinalLoadPlanHolidayBLL= new FinalLoadPlanHolidayService();
				return iFinalLoadPlanHolidayBLL;
			}
			set
			{
				iFinalLoadPlanHolidayBLL= value;
			}
		}
		#endregion

		#region 66 业务接口 IFinalLoadPlanJobRecordDAL
		IFinalLoadPlanJobRecordBLL iFinalLoadPlanJobRecordBLL;
		public IFinalLoadPlanJobRecordBLL IFinalLoadPlanJobRecordBLL
		{
			get
			{
				if(iFinalLoadPlanJobRecordBLL==null)
					iFinalLoadPlanJobRecordBLL= new FinalLoadPlanJobRecordService();
				return iFinalLoadPlanJobRecordBLL;
			}
			set
			{
				iFinalLoadPlanJobRecordBLL= value;
			}
		}
		#endregion

		#region 67 业务接口 IFinalLoadPlanRPALogDAL
		IFinalLoadPlanRPALogBLL iFinalLoadPlanRPALogBLL;
		public IFinalLoadPlanRPALogBLL IFinalLoadPlanRPALogBLL
		{
			get
			{
				if(iFinalLoadPlanRPALogBLL==null)
					iFinalLoadPlanRPALogBLL= new FinalLoadPlanRPALogService();
				return iFinalLoadPlanRPALogBLL;
			}
			set
			{
				iFinalLoadPlanRPALogBLL= value;
			}
		}
		#endregion

		#region 68 业务接口 IFinalPo_Cancel_RecordDAL
		IFinalPo_Cancel_RecordBLL iFinalPo_Cancel_RecordBLL;
		public IFinalPo_Cancel_RecordBLL IFinalPo_Cancel_RecordBLL
		{
			get
			{
				if(iFinalPo_Cancel_RecordBLL==null)
					iFinalPo_Cancel_RecordBLL= new FinalPo_Cancel_RecordService();
				return iFinalPo_Cancel_RecordBLL;
			}
			set
			{
				iFinalPo_Cancel_RecordBLL= value;
			}
		}
		#endregion

		#region 69 业务接口 IFinalPoListDAL
		IFinalPoListBLL iFinalPoListBLL;
		public IFinalPoListBLL IFinalPoListBLL
		{
			get
			{
				if(iFinalPoListBLL==null)
					iFinalPoListBLL= new FinalPoListService();
				return iFinalPoListBLL;
			}
			set
			{
				iFinalPoListBLL= value;
			}
		}
		#endregion

		#region 70 业务接口 IFinalVendorInputDAL
		IFinalVendorInputBLL iFinalVendorInputBLL;
		public IFinalVendorInputBLL IFinalVendorInputBLL
		{
			get
			{
				if(iFinalVendorInputBLL==null)
					iFinalVendorInputBLL= new FinalVendorInputService();
				return iFinalVendorInputBLL;
			}
			set
			{
				iFinalVendorInputBLL= value;
			}
		}
		#endregion

		#region 71 业务接口 IFinalVendorInputLogDAL
		IFinalVendorInputLogBLL iFinalVendorInputLogBLL;
		public IFinalVendorInputLogBLL IFinalVendorInputLogBLL
		{
			get
			{
				if(iFinalVendorInputLogBLL==null)
					iFinalVendorInputLogBLL= new FinalVendorInputLogService();
				return iFinalVendorInputLogBLL;
			}
			set
			{
				iFinalVendorInputLogBLL= value;
			}
		}
		#endregion

		#region 72 业务接口 IFinalVendorInputTruckingDAL
		IFinalVendorInputTruckingBLL iFinalVendorInputTruckingBLL;
		public IFinalVendorInputTruckingBLL IFinalVendorInputTruckingBLL
		{
			get
			{
				if(iFinalVendorInputTruckingBLL==null)
					iFinalVendorInputTruckingBLL= new FinalVendorInputTruckingService();
				return iFinalVendorInputTruckingBLL;
			}
			set
			{
				iFinalVendorInputTruckingBLL= value;
			}
		}
		#endregion

		#region 73 业务接口 IfinanceChargeDAL
		IfinanceChargeBLL ifinanceChargeBLL;
		public IfinanceChargeBLL IfinanceChargeBLL
		{
			get
			{
				if(ifinanceChargeBLL==null)
					ifinanceChargeBLL= new financeChargeService();
				return ifinanceChargeBLL;
			}
			set
			{
				ifinanceChargeBLL= value;
			}
		}
		#endregion

		#region 74 业务接口 Iforwarder_codeDAL
		Iforwarder_codeBLL iforwarder_codeBLL;
		public Iforwarder_codeBLL Iforwarder_codeBLL
		{
			get
			{
				if(iforwarder_codeBLL==null)
					iforwarder_codeBLL= new forwarder_codeService();
				return iforwarder_codeBLL;
			}
			set
			{
				iforwarder_codeBLL= value;
			}
		}
		#endregion

		#region 75 业务接口 Iin_headDAL
		Iin_headBLL iin_headBLL;
		public Iin_headBLL Iin_headBLL
		{
			get
			{
				if(iin_headBLL==null)
					iin_headBLL= new in_headService();
				return iin_headBLL;
			}
			set
			{
				iin_headBLL= value;
			}
		}
		#endregion

		#region 76 业务接口 Iin_itemDAL
		Iin_itemBLL iin_itemBLL;
		public Iin_itemBLL Iin_itemBLL
		{
			get
			{
				if(iin_itemBLL==null)
					iin_itemBLL= new in_itemService();
				return iin_itemBLL;
			}
			set
			{
				iin_itemBLL= value;
			}
		}
		#endregion

		#region 77 业务接口 IIn2SoDAL
		IIn2SoBLL iIn2SoBLL;
		public IIn2SoBLL IIn2SoBLL
		{
			get
			{
				if(iIn2SoBLL==null)
					iIn2SoBLL= new In2SoService();
				return iIn2SoBLL;
			}
			set
			{
				iIn2SoBLL= value;
			}
		}
		#endregion

		#region 78 业务接口 IInDocContainerDAL
		IInDocContainerBLL iInDocContainerBLL;
		public IInDocContainerBLL IInDocContainerBLL
		{
			get
			{
				if(iInDocContainerBLL==null)
					iInDocContainerBLL= new InDocContainerService();
				return iInDocContainerBLL;
			}
			set
			{
				iInDocContainerBLL= value;
			}
		}
		#endregion

		#region 79 业务接口 IInDocVehicleDAL
		IInDocVehicleBLL iInDocVehicleBLL;
		public IInDocVehicleBLL IInDocVehicleBLL
		{
			get
			{
				if(iInDocVehicleBLL==null)
					iInDocVehicleBLL= new InDocVehicleService();
				return iInDocVehicleBLL;
			}
			set
			{
				iInDocVehicleBLL= value;
			}
		}
		#endregion

		#region 80 业务接口 IInheadDAL
		IInheadBLL iInheadBLL;
		public IInheadBLL IInheadBLL
		{
			get
			{
				if(iInheadBLL==null)
					iInheadBLL= new InheadService();
				return iInheadBLL;
			}
			set
			{
				iInheadBLL= value;
			}
		}
		#endregion

		#region 81 业务接口 IInListDAL
		IInListBLL iInListBLL;
		public IInListBLL IInListBLL
		{
			get
			{
				if(iInListBLL==null)
					iInListBLL= new InListService();
				return iInListBLL;
			}
			set
			{
				iInListBLL= value;
			}
		}
		#endregion

		#region 82 业务接口 IinvoiceDAL
		IinvoiceBLL iinvoiceBLL;
		public IinvoiceBLL IinvoiceBLL
		{
			get
			{
				if(iinvoiceBLL==null)
					iinvoiceBLL= new invoiceService();
				return iinvoiceBLL;
			}
			set
			{
				iinvoiceBLL= value;
			}
		}
		#endregion

		#region 83 业务接口 IinvoiceExchangeDAL
		IinvoiceExchangeBLL iinvoiceExchangeBLL;
		public IinvoiceExchangeBLL IinvoiceExchangeBLL
		{
			get
			{
				if(iinvoiceExchangeBLL==null)
					iinvoiceExchangeBLL= new invoiceExchangeService();
				return iinvoiceExchangeBLL;
			}
			set
			{
				iinvoiceExchangeBLL= value;
			}
		}
		#endregion

		#region 84 业务接口 IlatecomeDAL
		IlatecomeBLL ilatecomeBLL;
		public IlatecomeBLL IlatecomeBLL
		{
			get
			{
				if(ilatecomeBLL==null)
					ilatecomeBLL= new latecomeService();
				return ilatecomeBLL;
			}
			set
			{
				ilatecomeBLL= value;
			}
		}
		#endregion

		#region 85 业务接口 ILoad_FeeDAL
		ILoad_FeeBLL iLoad_FeeBLL;
		public ILoad_FeeBLL ILoad_FeeBLL
		{
			get
			{
				if(iLoad_FeeBLL==null)
					iLoad_FeeBLL= new Load_FeeService();
				return iLoad_FeeBLL;
			}
			set
			{
				iLoad_FeeBLL= value;
			}
		}
		#endregion

		#region 86 业务接口 ILoadingDAL
		ILoadingBLL iLoadingBLL;
		public ILoadingBLL ILoadingBLL
		{
			get
			{
				if(iLoadingBLL==null)
					iLoadingBLL= new LoadingService();
				return iLoadingBLL;
			}
			set
			{
				iLoadingBLL= value;
			}
		}
		#endregion

		#region 87 业务接口 ILoadPlanUpdateRecordDAL
		ILoadPlanUpdateRecordBLL iLoadPlanUpdateRecordBLL;
		public ILoadPlanUpdateRecordBLL ILoadPlanUpdateRecordBLL
		{
			get
			{
				if(iLoadPlanUpdateRecordBLL==null)
					iLoadPlanUpdateRecordBLL= new LoadPlanUpdateRecordService();
				return iLoadPlanUpdateRecordBLL;
			}
			set
			{
				iLoadPlanUpdateRecordBLL= value;
			}
		}
		#endregion

		#region 88 业务接口 ILPCont_InfoDAL
		ILPCont_InfoBLL iLPCont_InfoBLL;
		public ILPCont_InfoBLL ILPCont_InfoBLL
		{
			get
			{
				if(iLPCont_InfoBLL==null)
					iLPCont_InfoBLL= new LPCont_InfoService();
				return iLPCont_InfoBLL;
			}
			set
			{
				iLPCont_InfoBLL= value;
			}
		}
		#endregion

		#region 89 业务接口 ILPStatusDAL
		ILPStatusBLL iLPStatusBLL;
		public ILPStatusBLL ILPStatusBLL
		{
			get
			{
				if(iLPStatusBLL==null)
					iLPStatusBLL= new LPStatusService();
				return iLPStatusBLL;
			}
			set
			{
				iLPStatusBLL= value;
			}
		}
		#endregion

		#region 90 业务接口 IMaxIdDAL
		IMaxIdBLL iMaxIdBLL;
		public IMaxIdBLL IMaxIdBLL
		{
			get
			{
				if(iMaxIdBLL==null)
					iMaxIdBLL= new MaxIdService();
				return iMaxIdBLL;
			}
			set
			{
				iMaxIdBLL= value;
			}
		}
		#endregion

		#region 91 业务接口 InewpackingDAL
		InewpackingBLL inewpackingBLL;
		public InewpackingBLL InewpackingBLL
		{
			get
			{
				if(inewpackingBLL==null)
					inewpackingBLL= new newpackingService();
				return inewpackingBLL;
			}
			set
			{
				inewpackingBLL= value;
			}
		}
		#endregion

		#region 92 业务接口 InewpacklistDAL
		InewpacklistBLL inewpacklistBLL;
		public InewpacklistBLL InewpacklistBLL
		{
			get
			{
				if(inewpacklistBLL==null)
					inewpacklistBLL= new newpacklistService();
				return inewpacklistBLL;
			}
			set
			{
				inewpacklistBLL= value;
			}
		}
		#endregion

		#region 93 业务接口 Iout_headDAL
		Iout_headBLL iout_headBLL;
		public Iout_headBLL Iout_headBLL
		{
			get
			{
				if(iout_headBLL==null)
					iout_headBLL= new out_headService();
				return iout_headBLL;
			}
			set
			{
				iout_headBLL= value;
			}
		}
		#endregion

		#region 94 业务接口 Iout_head_cyDAL
		Iout_head_cyBLL iout_head_cyBLL;
		public Iout_head_cyBLL Iout_head_cyBLL
		{
			get
			{
				if(iout_head_cyBLL==null)
					iout_head_cyBLL= new out_head_cyService();
				return iout_head_cyBLL;
			}
			set
			{
				iout_head_cyBLL= value;
			}
		}
		#endregion

		#region 95 业务接口 Iout_itemDAL
		Iout_itemBLL iout_itemBLL;
		public Iout_itemBLL Iout_itemBLL
		{
			get
			{
				if(iout_itemBLL==null)
					iout_itemBLL= new out_itemService();
				return iout_itemBLL;
			}
			set
			{
				iout_itemBLL= value;
			}
		}
		#endregion

		#region 96 业务接口 Iout_item_cyDAL
		Iout_item_cyBLL iout_item_cyBLL;
		public Iout_item_cyBLL Iout_item_cyBLL
		{
			get
			{
				if(iout_item_cyBLL==null)
					iout_item_cyBLL= new out_item_cyService();
				return iout_item_cyBLL;
			}
			set
			{
				iout_item_cyBLL= value;
			}
		}
		#endregion

		#region 97 业务接口 IOutDocContainerDAL
		IOutDocContainerBLL iOutDocContainerBLL;
		public IOutDocContainerBLL IOutDocContainerBLL
		{
			get
			{
				if(iOutDocContainerBLL==null)
					iOutDocContainerBLL= new OutDocContainerService();
				return iOutDocContainerBLL;
			}
			set
			{
				iOutDocContainerBLL= value;
			}
		}
		#endregion

		#region 98 业务接口 IOutDocVehicleDAL
		IOutDocVehicleBLL iOutDocVehicleBLL;
		public IOutDocVehicleBLL IOutDocVehicleBLL
		{
			get
			{
				if(iOutDocVehicleBLL==null)
					iOutDocVehicleBLL= new OutDocVehicleService();
				return iOutDocVehicleBLL;
			}
			set
			{
				iOutDocVehicleBLL= value;
			}
		}
		#endregion

		#region 99 业务接口 IOutheadDAL
		IOutheadBLL iOutheadBLL;
		public IOutheadBLL IOutheadBLL
		{
			get
			{
				if(iOutheadBLL==null)
					iOutheadBLL= new OutheadService();
				return iOutheadBLL;
			}
			set
			{
				iOutheadBLL= value;
			}
		}
		#endregion

		#region 100 业务接口 IOutListDAL
		IOutListBLL iOutListBLL;
		public IOutListBLL IOutListBLL
		{
			get
			{
				if(iOutListBLL==null)
					iOutListBLL= new OutListService();
				return iOutListBLL;
			}
			set
			{
				iOutListBLL= value;
			}
		}
		#endregion

		#region 101 业务接口 IOutListItemsDAL
		IOutListItemsBLL iOutListItemsBLL;
		public IOutListItemsBLL IOutListItemsBLL
		{
			get
			{
				if(iOutListItemsBLL==null)
					iOutListItemsBLL= new OutListItemsService();
				return iOutListItemsBLL;
			}
			set
			{
				iOutListItemsBLL= value;
			}
		}
		#endregion

		#region 102 业务接口 Ipick_return_chargeDAL
		Ipick_return_chargeBLL ipick_return_chargeBLL;
		public Ipick_return_chargeBLL Ipick_return_chargeBLL
		{
			get
			{
				if(ipick_return_chargeBLL==null)
					ipick_return_chargeBLL= new pick_return_chargeService();
				return ipick_return_chargeBLL;
			}
			set
			{
				ipick_return_chargeBLL= value;
			}
		}
		#endregion

		#region 103 业务接口 IPortDAL
		IPortBLL iPortBLL;
		public IPortBLL IPortBLL
		{
			get
			{
				if(iPortBLL==null)
					iPortBLL= new PortService();
				return iPortBLL;
			}
			set
			{
				iPortBLL= value;
			}
		}
		#endregion

		#region 104 业务接口 IProdesOfVIFADAL
		IProdesOfVIFABLL iProdesOfVIFABLL;
		public IProdesOfVIFABLL IProdesOfVIFABLL
		{
			get
			{
				if(iProdesOfVIFABLL==null)
					iProdesOfVIFABLL= new ProdesOfVIFAService();
				return iProdesOfVIFABLL;
			}
			set
			{
				iProdesOfVIFABLL= value;
			}
		}
		#endregion

		#region 105 业务接口 Irec_amountDAL
		Irec_amountBLL irec_amountBLL;
		public Irec_amountBLL Irec_amountBLL
		{
			get
			{
				if(irec_amountBLL==null)
					irec_amountBLL= new rec_amountService();
				return irec_amountBLL;
			}
			set
			{
				irec_amountBLL= value;
			}
		}
		#endregion

		#region 106 业务接口 IrecdtlDAL
		IrecdtlBLL irecdtlBLL;
		public IrecdtlBLL IrecdtlBLL
		{
			get
			{
				if(irecdtlBLL==null)
					irecdtlBLL= new recdtlService();
				return irecdtlBLL;
			}
			set
			{
				irecdtlBLL= value;
			}
		}
		#endregion

		#region 107 业务接口 IrecheadDAL
		IrecheadBLL irecheadBLL;
		public IrecheadBLL IrecheadBLL
		{
			get
			{
				if(irecheadBLL==null)
					irecheadBLL= new recheadService();
				return irecheadBLL;
			}
			set
			{
				irecheadBLL= value;
			}
		}
		#endregion

		#region 108 业务接口 IRecRegistrationHeadDAL
		IRecRegistrationHeadBLL iRecRegistrationHeadBLL;
		public IRecRegistrationHeadBLL IRecRegistrationHeadBLL
		{
			get
			{
				if(iRecRegistrationHeadBLL==null)
					iRecRegistrationHeadBLL= new RecRegistrationHeadService();
				return iRecRegistrationHeadBLL;
			}
			set
			{
				iRecRegistrationHeadBLL= value;
			}
		}
		#endregion

		#region 109 业务接口 IRecRegistrationItemsDAL
		IRecRegistrationItemsBLL iRecRegistrationItemsBLL;
		public IRecRegistrationItemsBLL IRecRegistrationItemsBLL
		{
			get
			{
				if(iRecRegistrationItemsBLL==null)
					iRecRegistrationItemsBLL= new RecRegistrationItemsService();
				return iRecRegistrationItemsBLL;
			}
			set
			{
				iRecRegistrationItemsBLL= value;
			}
		}
		#endregion

		#region 110 业务接口 IRecRegVehicleDAL
		IRecRegVehicleBLL iRecRegVehicleBLL;
		public IRecRegVehicleBLL IRecRegVehicleBLL
		{
			get
			{
				if(iRecRegVehicleBLL==null)
					iRecRegVehicleBLL= new RecRegVehicleService();
				return iRecRegVehicleBLL;
			}
			set
			{
				iRecRegVehicleBLL= value;
			}
		}
		#endregion

		#region 111 业务接口 IrepertoryDAL
		IrepertoryBLL irepertoryBLL;
		public IrepertoryBLL IrepertoryBLL
		{
			get
			{
				if(irepertoryBLL==null)
					irepertoryBLL= new repertoryService();
				return irepertoryBLL;
			}
			set
			{
				irepertoryBLL= value;
			}
		}
		#endregion

		#region 112 业务接口 IserviceDAL
		IserviceBLL iserviceBLL;
		public IserviceBLL IserviceBLL
		{
			get
			{
				if(iserviceBLL==null)
					iserviceBLL= new serviceService();
				return iserviceBLL;
			}
			set
			{
				iserviceBLL= value;
			}
		}
		#endregion

		#region 113 业务接口 IshipcorpDAL
		IshipcorpBLL ishipcorpBLL;
		public IshipcorpBLL IshipcorpBLL
		{
			get
			{
				if(ishipcorpBLL==null)
					ishipcorpBLL= new shipcorpService();
				return ishipcorpBLL;
			}
			set
			{
				ishipcorpBLL= value;
			}
		}
		#endregion

		#region 114 业务接口 IShipperNameListDAL
		IShipperNameListBLL iShipperNameListBLL;
		public IShipperNameListBLL IShipperNameListBLL
		{
			get
			{
				if(iShipperNameListBLL==null)
					iShipperNameListBLL= new ShipperNameListService();
				return iShipperNameListBLL;
			}
			set
			{
				iShipperNameListBLL= value;
			}
		}
		#endregion

		#region 115 业务接口 IShipToDAL
		IShipToBLL iShipToBLL;
		public IShipToBLL IShipToBLL
		{
			get
			{
				if(iShipToBLL==null)
					iShipToBLL= new ShipToService();
				return iShipToBLL;
			}
			set
			{
				iShipToBLL= value;
			}
		}
		#endregion

		#region 116 业务接口 ISMFOBDebitNoteRateAutomaticgrowthDAL
		ISMFOBDebitNoteRateAutomaticgrowthBLL iSMFOBDebitNoteRateAutomaticgrowthBLL;
		public ISMFOBDebitNoteRateAutomaticgrowthBLL ISMFOBDebitNoteRateAutomaticgrowthBLL
		{
			get
			{
				if(iSMFOBDebitNoteRateAutomaticgrowthBLL==null)
					iSMFOBDebitNoteRateAutomaticgrowthBLL= new SMFOBDebitNoteRateAutomaticgrowthService();
				return iSMFOBDebitNoteRateAutomaticgrowthBLL;
			}
			set
			{
				iSMFOBDebitNoteRateAutomaticgrowthBLL= value;
			}
		}
		#endregion

		#region 117 业务接口 Ispe_opertypeDAL
		Ispe_opertypeBLL ispe_opertypeBLL;
		public Ispe_opertypeBLL Ispe_opertypeBLL
		{
			get
			{
				if(ispe_opertypeBLL==null)
					ispe_opertypeBLL= new spe_opertypeService();
				return ispe_opertypeBLL;
			}
			set
			{
				ispe_opertypeBLL= value;
			}
		}
		#endregion

		#region 118 业务接口 IspecialDAL
		IspecialBLL ispecialBLL;
		public IspecialBLL IspecialBLL
		{
			get
			{
				if(ispecialBLL==null)
					ispecialBLL= new specialService();
				return ispecialBLL;
			}
			set
			{
				ispecialBLL= value;
			}
		}
		#endregion

		#region 119 业务接口 Ispecial_itemDAL
		Ispecial_itemBLL ispecial_itemBLL;
		public Ispecial_itemBLL Ispecial_itemBLL
		{
			get
			{
				if(ispecial_itemBLL==null)
					ispecial_itemBLL= new special_itemService();
				return ispecial_itemBLL;
			}
			set
			{
				ispecial_itemBLL= value;
			}
		}
		#endregion

		#region 120 业务接口 ISpsOperateDAL
		ISpsOperateBLL iSpsOperateBLL;
		public ISpsOperateBLL ISpsOperateBLL
		{
			get
			{
				if(iSpsOperateBLL==null)
					iSpsOperateBLL= new SpsOperateService();
				return iSpsOperateBLL;
			}
			set
			{
				iSpsOperateBLL= value;
			}
		}
		#endregion

		#region 121 业务接口 ISys_DepartmentDAL
		ISys_DepartmentBLL iSys_DepartmentBLL;
		public ISys_DepartmentBLL ISys_DepartmentBLL
		{
			get
			{
				if(iSys_DepartmentBLL==null)
					iSys_DepartmentBLL= new Sys_DepartmentService();
				return iSys_DepartmentBLL;
			}
			set
			{
				iSys_DepartmentBLL= value;
			}
		}
		#endregion

		#region 122 业务接口 ISys_EasyUIDAL
		ISys_EasyUIBLL iSys_EasyUIBLL;
		public ISys_EasyUIBLL ISys_EasyUIBLL
		{
			get
			{
				if(iSys_EasyUIBLL==null)
					iSys_EasyUIBLL= new Sys_EasyUIService();
				return iSys_EasyUIBLL;
			}
			set
			{
				iSys_EasyUIBLL= value;
			}
		}
		#endregion

		#region 123 业务接口 ISys_LogDAL
		ISys_LogBLL iSys_LogBLL;
		public ISys_LogBLL ISys_LogBLL
		{
			get
			{
				if(iSys_LogBLL==null)
					iSys_LogBLL= new Sys_LogService();
				return iSys_LogBLL;
			}
			set
			{
				iSys_LogBLL= value;
			}
		}
		#endregion

		#region 124 业务接口 ISys_PermissionDAL
		ISys_PermissionBLL iSys_PermissionBLL;
		public ISys_PermissionBLL ISys_PermissionBLL
		{
			get
			{
				if(iSys_PermissionBLL==null)
					iSys_PermissionBLL= new Sys_PermissionService();
				return iSys_PermissionBLL;
			}
			set
			{
				iSys_PermissionBLL= value;
			}
		}
		#endregion

		#region 125 业务接口 ISys_RoleDAL
		ISys_RoleBLL iSys_RoleBLL;
		public ISys_RoleBLL ISys_RoleBLL
		{
			get
			{
				if(iSys_RoleBLL==null)
					iSys_RoleBLL= new Sys_RoleService();
				return iSys_RoleBLL;
			}
			set
			{
				iSys_RoleBLL= value;
			}
		}
		#endregion

		#region 126 业务接口 ISys_RolePermissionDAL
		ISys_RolePermissionBLL iSys_RolePermissionBLL;
		public ISys_RolePermissionBLL ISys_RolePermissionBLL
		{
			get
			{
				if(iSys_RolePermissionBLL==null)
					iSys_RolePermissionBLL= new Sys_RolePermissionService();
				return iSys_RolePermissionBLL;
			}
			set
			{
				iSys_RolePermissionBLL= value;
			}
		}
		#endregion

		#region 127 业务接口 ISys_UserInfoDAL
		ISys_UserInfoBLL iSys_UserInfoBLL;
		public ISys_UserInfoBLL ISys_UserInfoBLL
		{
			get
			{
				if(iSys_UserInfoBLL==null)
					iSys_UserInfoBLL= new Sys_UserInfoService();
				return iSys_UserInfoBLL;
			}
			set
			{
				iSys_UserInfoBLL= value;
			}
		}
		#endregion

		#region 128 业务接口 ISys_UserRoleDAL
		ISys_UserRoleBLL iSys_UserRoleBLL;
		public ISys_UserRoleBLL ISys_UserRoleBLL
		{
			get
			{
				if(iSys_UserRoleBLL==null)
					iSys_UserRoleBLL= new Sys_UserRoleService();
				return iSys_UserRoleBLL;
			}
			set
			{
				iSys_UserRoleBLL= value;
			}
		}
		#endregion

		#region 129 业务接口 ISys_UserSettingDAL
		ISys_UserSettingBLL iSys_UserSettingBLL;
		public ISys_UserSettingBLL ISys_UserSettingBLL
		{
			get
			{
				if(iSys_UserSettingBLL==null)
					iSys_UserSettingBLL= new Sys_UserSettingService();
				return iSys_UserSettingBLL;
			}
			set
			{
				iSys_UserSettingBLL= value;
			}
		}
		#endregion

		#region 130 业务接口 ISys_UserVipPermissionDAL
		ISys_UserVipPermissionBLL iSys_UserVipPermissionBLL;
		public ISys_UserVipPermissionBLL ISys_UserVipPermissionBLL
		{
			get
			{
				if(iSys_UserVipPermissionBLL==null)
					iSys_UserVipPermissionBLL= new Sys_UserVipPermissionService();
				return iSys_UserVipPermissionBLL;
			}
			set
			{
				iSys_UserVipPermissionBLL= value;
			}
		}
		#endregion

		#region 131 业务接口 IsysdiagramsDAL
		IsysdiagramsBLL isysdiagramsBLL;
		public IsysdiagramsBLL IsysdiagramsBLL
		{
			get
			{
				if(isysdiagramsBLL==null)
					isysdiagramsBLL= new sysdiagramsService();
				return isysdiagramsBLL;
			}
			set
			{
				isysdiagramsBLL= value;
			}
		}
		#endregion

		#region 132 业务接口 ITruck_AccountDAL
		ITruck_AccountBLL iTruck_AccountBLL;
		public ITruck_AccountBLL ITruck_AccountBLL
		{
			get
			{
				if(iTruck_AccountBLL==null)
					iTruck_AccountBLL= new Truck_AccountService();
				return iTruck_AccountBLL;
			}
			set
			{
				iTruck_AccountBLL= value;
			}
		}
		#endregion

		#region 133 业务接口 ITruck_Account2DAL
		ITruck_Account2BLL iTruck_Account2BLL;
		public ITruck_Account2BLL ITruck_Account2BLL
		{
			get
			{
				if(iTruck_Account2BLL==null)
					iTruck_Account2BLL= new Truck_Account2Service();
				return iTruck_Account2BLL;
			}
			set
			{
				iTruck_Account2BLL= value;
			}
		}
		#endregion

		#region 134 业务接口 ITruck_Booking_ChargeDAL
		ITruck_Booking_ChargeBLL iTruck_Booking_ChargeBLL;
		public ITruck_Booking_ChargeBLL ITruck_Booking_ChargeBLL
		{
			get
			{
				if(iTruck_Booking_ChargeBLL==null)
					iTruck_Booking_ChargeBLL= new Truck_Booking_ChargeService();
				return iTruck_Booking_ChargeBLL;
			}
			set
			{
				iTruck_Booking_ChargeBLL= value;
			}
		}
		#endregion

		#region 135 业务接口 ITruck_Booking_ClientChargeDAL
		ITruck_Booking_ClientChargeBLL iTruck_Booking_ClientChargeBLL;
		public ITruck_Booking_ClientChargeBLL ITruck_Booking_ClientChargeBLL
		{
			get
			{
				if(iTruck_Booking_ClientChargeBLL==null)
					iTruck_Booking_ClientChargeBLL= new Truck_Booking_ClientChargeService();
				return iTruck_Booking_ClientChargeBLL;
			}
			set
			{
				iTruck_Booking_ClientChargeBLL= value;
			}
		}
		#endregion

		#region 136 业务接口 ITruck_Booking_DetailDAL
		ITruck_Booking_DetailBLL iTruck_Booking_DetailBLL;
		public ITruck_Booking_DetailBLL ITruck_Booking_DetailBLL
		{
			get
			{
				if(iTruck_Booking_DetailBLL==null)
					iTruck_Booking_DetailBLL= new Truck_Booking_DetailService();
				return iTruck_Booking_DetailBLL;
			}
			set
			{
				iTruck_Booking_DetailBLL= value;
			}
		}
		#endregion

		#region 137 业务接口 ITruck_Booking_FileDAL
		ITruck_Booking_FileBLL iTruck_Booking_FileBLL;
		public ITruck_Booking_FileBLL ITruck_Booking_FileBLL
		{
			get
			{
				if(iTruck_Booking_FileBLL==null)
					iTruck_Booking_FileBLL= new Truck_Booking_FileService();
				return iTruck_Booking_FileBLL;
			}
			set
			{
				iTruck_Booking_FileBLL= value;
			}
		}
		#endregion

		#region 138 业务接口 ITruck_Booking_HeadDAL
		ITruck_Booking_HeadBLL iTruck_Booking_HeadBLL;
		public ITruck_Booking_HeadBLL ITruck_Booking_HeadBLL
		{
			get
			{
				if(iTruck_Booking_HeadBLL==null)
					iTruck_Booking_HeadBLL= new Truck_Booking_HeadService();
				return iTruck_Booking_HeadBLL;
			}
			set
			{
				iTruck_Booking_HeadBLL= value;
			}
		}
		#endregion

		#region 139 业务接口 ITruck_Booking_RegDAL
		ITruck_Booking_RegBLL iTruck_Booking_RegBLL;
		public ITruck_Booking_RegBLL ITruck_Booking_RegBLL
		{
			get
			{
				if(iTruck_Booking_RegBLL==null)
					iTruck_Booking_RegBLL= new Truck_Booking_RegService();
				return iTruck_Booking_RegBLL;
			}
			set
			{
				iTruck_Booking_RegBLL= value;
			}
		}
		#endregion

		#region 140 业务接口 ITruck_CBM_WeightDAL
		ITruck_CBM_WeightBLL iTruck_CBM_WeightBLL;
		public ITruck_CBM_WeightBLL ITruck_CBM_WeightBLL
		{
			get
			{
				if(iTruck_CBM_WeightBLL==null)
					iTruck_CBM_WeightBLL= new Truck_CBM_WeightService();
				return iTruck_CBM_WeightBLL;
			}
			set
			{
				iTruck_CBM_WeightBLL= value;
			}
		}
		#endregion

		#region 141 业务接口 ITruck_ChargeNameDAL
		ITruck_ChargeNameBLL iTruck_ChargeNameBLL;
		public ITruck_ChargeNameBLL ITruck_ChargeNameBLL
		{
			get
			{
				if(iTruck_ChargeNameBLL==null)
					iTruck_ChargeNameBLL= new Truck_ChargeNameService();
				return iTruck_ChargeNameBLL;
			}
			set
			{
				iTruck_ChargeNameBLL= value;
			}
		}
		#endregion

		#region 142 业务接口 ITruck_ClientDAL
		ITruck_ClientBLL iTruck_ClientBLL;
		public ITruck_ClientBLL ITruck_ClientBLL
		{
			get
			{
				if(iTruck_ClientBLL==null)
					iTruck_ClientBLL= new Truck_ClientService();
				return iTruck_ClientBLL;
			}
			set
			{
				iTruck_ClientBLL= value;
			}
		}
		#endregion

		#region 143 业务接口 ITruck_CompanyDAL
		ITruck_CompanyBLL iTruck_CompanyBLL;
		public ITruck_CompanyBLL ITruck_CompanyBLL
		{
			get
			{
				if(iTruck_CompanyBLL==null)
					iTruck_CompanyBLL= new Truck_CompanyService();
				return iTruck_CompanyBLL;
			}
			set
			{
				iTruck_CompanyBLL= value;
			}
		}
		#endregion

		#region 144 业务接口 ITruck_Delivery_AddressDAL
		ITruck_Delivery_AddressBLL iTruck_Delivery_AddressBLL;
		public ITruck_Delivery_AddressBLL ITruck_Delivery_AddressBLL
		{
			get
			{
				if(iTruck_Delivery_AddressBLL==null)
					iTruck_Delivery_AddressBLL= new Truck_Delivery_AddressService();
				return iTruck_Delivery_AddressBLL;
			}
			set
			{
				iTruck_Delivery_AddressBLL= value;
			}
		}
		#endregion

		#region 145 业务接口 ITruck_DestDAL
		ITruck_DestBLL iTruck_DestBLL;
		public ITruck_DestBLL ITruck_DestBLL
		{
			get
			{
				if(iTruck_DestBLL==null)
					iTruck_DestBLL= new Truck_DestService();
				return iTruck_DestBLL;
			}
			set
			{
				iTruck_DestBLL= value;
			}
		}
		#endregion

		#region 146 业务接口 ITruck_Exchange_RateDAL
		ITruck_Exchange_RateBLL iTruck_Exchange_RateBLL;
		public ITruck_Exchange_RateBLL ITruck_Exchange_RateBLL
		{
			get
			{
				if(iTruck_Exchange_RateBLL==null)
					iTruck_Exchange_RateBLL= new Truck_Exchange_RateService();
				return iTruck_Exchange_RateBLL;
			}
			set
			{
				iTruck_Exchange_RateBLL= value;
			}
		}
		#endregion

		#region 147 业务接口 ITruck_InvoiceDAL
		ITruck_InvoiceBLL iTruck_InvoiceBLL;
		public ITruck_InvoiceBLL ITruck_InvoiceBLL
		{
			get
			{
				if(iTruck_InvoiceBLL==null)
					iTruck_InvoiceBLL= new Truck_InvoiceService();
				return iTruck_InvoiceBLL;
			}
			set
			{
				iTruck_InvoiceBLL= value;
			}
		}
		#endregion

		#region 148 业务接口 ITruck_Invoice_CodeDAL
		ITruck_Invoice_CodeBLL iTruck_Invoice_CodeBLL;
		public ITruck_Invoice_CodeBLL ITruck_Invoice_CodeBLL
		{
			get
			{
				if(iTruck_Invoice_CodeBLL==null)
					iTruck_Invoice_CodeBLL= new Truck_Invoice_CodeService();
				return iTruck_Invoice_CodeBLL;
			}
			set
			{
				iTruck_Invoice_CodeBLL= value;
			}
		}
		#endregion

		#region 149 业务接口 ITruck_Invoice_InfoDAL
		ITruck_Invoice_InfoBLL iTruck_Invoice_InfoBLL;
		public ITruck_Invoice_InfoBLL ITruck_Invoice_InfoBLL
		{
			get
			{
				if(iTruck_Invoice_InfoBLL==null)
					iTruck_Invoice_InfoBLL= new Truck_Invoice_InfoService();
				return iTruck_Invoice_InfoBLL;
			}
			set
			{
				iTruck_Invoice_InfoBLL= value;
			}
		}
		#endregion

		#region 150 业务接口 ITruck_Invoice_Info_AddDAL
		ITruck_Invoice_Info_AddBLL iTruck_Invoice_Info_AddBLL;
		public ITruck_Invoice_Info_AddBLL ITruck_Invoice_Info_AddBLL
		{
			get
			{
				if(iTruck_Invoice_Info_AddBLL==null)
					iTruck_Invoice_Info_AddBLL= new Truck_Invoice_Info_AddService();
				return iTruck_Invoice_Info_AddBLL;
			}
			set
			{
				iTruck_Invoice_Info_AddBLL= value;
			}
		}
		#endregion

		#region 151 业务接口 ITruck_Loading_AddressDAL
		ITruck_Loading_AddressBLL iTruck_Loading_AddressBLL;
		public ITruck_Loading_AddressBLL ITruck_Loading_AddressBLL
		{
			get
			{
				if(iTruck_Loading_AddressBLL==null)
					iTruck_Loading_AddressBLL= new Truck_Loading_AddressService();
				return iTruck_Loading_AddressBLL;
			}
			set
			{
				iTruck_Loading_AddressBLL= value;
			}
		}
		#endregion

		#region 152 业务接口 ITruck_PackingListDAL
		ITruck_PackingListBLL iTruck_PackingListBLL;
		public ITruck_PackingListBLL ITruck_PackingListBLL
		{
			get
			{
				if(iTruck_PackingListBLL==null)
					iTruck_PackingListBLL= new Truck_PackingListService();
				return iTruck_PackingListBLL;
			}
			set
			{
				iTruck_PackingListBLL= value;
			}
		}
		#endregion

		#region 153 业务接口 ITruck_PODAL
		ITruck_POBLL iTruck_POBLL;
		public ITruck_POBLL ITruck_POBLL
		{
			get
			{
				if(iTruck_POBLL==null)
					iTruck_POBLL= new Truck_POService();
				return iTruck_POBLL;
			}
			set
			{
				iTruck_POBLL= value;
			}
		}
		#endregion

		#region 154 业务接口 ITruck_Storage_YardDAL
		ITruck_Storage_YardBLL iTruck_Storage_YardBLL;
		public ITruck_Storage_YardBLL ITruck_Storage_YardBLL
		{
			get
			{
				if(iTruck_Storage_YardBLL==null)
					iTruck_Storage_YardBLL= new Truck_Storage_YardService();
				return iTruck_Storage_YardBLL;
			}
			set
			{
				iTruck_Storage_YardBLL= value;
			}
		}
		#endregion

		#region 155 业务接口 ITruck_VendorDAL
		ITruck_VendorBLL iTruck_VendorBLL;
		public ITruck_VendorBLL ITruck_VendorBLL
		{
			get
			{
				if(iTruck_VendorBLL==null)
					iTruck_VendorBLL= new Truck_VendorService();
				return iTruck_VendorBLL;
			}
			set
			{
				iTruck_VendorBLL= value;
			}
		}
		#endregion

		#region 156 业务接口 ITruck_Vendor_ClientDAL
		ITruck_Vendor_ClientBLL iTruck_Vendor_ClientBLL;
		public ITruck_Vendor_ClientBLL ITruck_Vendor_ClientBLL
		{
			get
			{
				if(iTruck_Vendor_ClientBLL==null)
					iTruck_Vendor_ClientBLL= new Truck_Vendor_ClientService();
				return iTruck_Vendor_ClientBLL;
			}
			set
			{
				iTruck_Vendor_ClientBLL= value;
			}
		}
		#endregion

		#region 157 业务接口 ITruck_WarehouseDAL
		ITruck_WarehouseBLL iTruck_WarehouseBLL;
		public ITruck_WarehouseBLL ITruck_WarehouseBLL
		{
			get
			{
				if(iTruck_WarehouseBLL==null)
					iTruck_WarehouseBLL= new Truck_WarehouseService();
				return iTruck_WarehouseBLL;
			}
			set
			{
				iTruck_WarehouseBLL= value;
			}
		}
		#endregion

		#region 158 业务接口 ITruckUnLoadTimeDAL
		ITruckUnLoadTimeBLL iTruckUnLoadTimeBLL;
		public ITruckUnLoadTimeBLL ITruckUnLoadTimeBLL
		{
			get
			{
				if(iTruckUnLoadTimeBLL==null)
					iTruckUnLoadTimeBLL= new TruckUnLoadTimeService();
				return iTruckUnLoadTimeBLL;
			}
			set
			{
				iTruckUnLoadTimeBLL= value;
			}
		}
		#endregion

		#region 159 业务接口 IturnoverDAL
		IturnoverBLL iturnoverBLL;
		public IturnoverBLL IturnoverBLL
		{
			get
			{
				if(iturnoverBLL==null)
					iturnoverBLL= new turnoverService();
				return iturnoverBLL;
			}
			set
			{
				iturnoverBLL= value;
			}
		}
		#endregion

		#region 160 业务接口 IunitDAL
		IunitBLL iunitBLL;
		public IunitBLL IunitBLL
		{
			get
			{
				if(iunitBLL==null)
					iunitBLL= new unitService();
				return iunitBLL;
			}
			set
			{
				iunitBLL= value;
			}
		}
		#endregion

		#region 161 业务接口 IUnloadingDAL
		IUnloadingBLL iUnloadingBLL;
		public IUnloadingBLL IUnloadingBLL
		{
			get
			{
				if(iUnloadingBLL==null)
					iUnloadingBLL= new UnloadingService();
				return iUnloadingBLL;
			}
			set
			{
				iUnloadingBLL= value;
			}
		}
		#endregion

		#region 162 业务接口 IUser_PasswordDAL
		IUser_PasswordBLL iUser_PasswordBLL;
		public IUser_PasswordBLL IUser_PasswordBLL
		{
			get
			{
				if(iUser_PasswordBLL==null)
					iUser_PasswordBLL= new User_PasswordService();
				return iUser_PasswordBLL;
			}
			set
			{
				iUser_PasswordBLL= value;
			}
		}
		#endregion

		#region 163 业务接口 IuserlogDAL
		IuserlogBLL iuserlogBLL;
		public IuserlogBLL IuserlogBLL
		{
			get
			{
				if(iuserlogBLL==null)
					iuserlogBLL= new userlogService();
				return iuserlogBLL;
			}
			set
			{
				iuserlogBLL= value;
			}
		}
		#endregion

		#region 164 业务接口 IVehicleDAL
		IVehicleBLL iVehicleBLL;
		public IVehicleBLL IVehicleBLL
		{
			get
			{
				if(iVehicleBLL==null)
					iVehicleBLL= new VehicleService();
				return iVehicleBLL;
			}
			set
			{
				iVehicleBLL= value;
			}
		}
		#endregion

		#region 165 业务接口 IvendorDAL
		IvendorBLL ivendorBLL;
		public IvendorBLL IvendorBLL
		{
			get
			{
				if(ivendorBLL==null)
					ivendorBLL= new vendorService();
				return ivendorBLL;
			}
			set
			{
				ivendorBLL= value;
			}
		}
		#endregion

		#region 166 业务接口 IVendorInfoDAL
		IVendorInfoBLL iVendorInfoBLL;
		public IVendorInfoBLL IVendorInfoBLL
		{
			get
			{
				if(iVendorInfoBLL==null)
					iVendorInfoBLL= new VendorInfoService();
				return iVendorInfoBLL;
			}
			set
			{
				iVendorInfoBLL= value;
			}
		}
		#endregion

		#region 167 业务接口 IvesselDAL
		IvesselBLL ivesselBLL;
		public IvesselBLL IvesselBLL
		{
			get
			{
				if(ivesselBLL==null)
					ivesselBLL= new vesselService();
				return ivesselBLL;
			}
			set
			{
				ivesselBLL= value;
			}
		}
		#endregion

		#region 168 业务接口 IwhsDAL
		IwhsBLL iwhsBLL;
		public IwhsBLL IwhsBLL
		{
			get
			{
				if(iwhsBLL==null)
					iwhsBLL= new whsService();
				return iwhsBLL;
			}
			set
			{
				iwhsBLL= value;
			}
		}
		#endregion

		#region 169 业务接口 IypmfuserDAL
		IypmfuserBLL iypmfuserBLL;
		public IypmfuserBLL IypmfuserBLL
		{
			get
			{
				if(iypmfuserBLL==null)
					iypmfuserBLL= new ypmfuserService();
				return iypmfuserBLL;
			}
			set
			{
				iypmfuserBLL= value;
			}
		}
		#endregion

    }

}