﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSystemProject.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QSoft_WUEntities : DbContext
    {
        public QSoft_WUEntities()
            : base("name=QSoft_WUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alccost> alccost { get; set; }
        public virtual DbSet<AROption> AROption { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<causeLose_pm> causeLose_pm { get; set; }
        public virtual DbSet<Corp> Corp { get; set; }
        public virtual DbSet<CQOption> CQOption { get; set; }
        public virtual DbSet<CreditTermType> CreditTermType { get; set; }
        public virtual DbSet<crepdoc_pm> crepdoc_pm { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerZone> CustomerZone { get; set; }
        public virtual DbSet<Depart> Depart { get; set; }
        public virtual DbSet<@do> @do { get; set; }
        public virtual DbSet<DodocNo> DodocNo { get; set; }
        public virtual DbSet<door> door { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeGroup> EmployeeGroup { get; set; }
        public virtual DbSet<EMTranspArea> EMTranspArea { get; set; }
        public virtual DbSet<Factory> Factory { get; set; }
        public virtual DbSet<GLOption> GLOption { get; set; }
        public virtual DbSet<Gmachine> Gmachine { get; set; }
        public virtual DbSet<grndoc> grndoc { get; set; }
        public virtual DbSet<Groupcustomer> Groupcustomer { get; set; }
        public virtual DbSet<Grouping> Grouping { get; set; }
        public virtual DbSet<Groupproduct> Groupproduct { get; set; }
        public virtual DbSet<GroupSupplier> GroupSupplier { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<irepdoc_pm> irepdoc_pm { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<Machine_pms> Machine_pms { get; set; }
        public virtual DbSet<Machinept> Machinept { get; set; }
        public virtual DbSet<MCDocNo> MCDocNo { get; set; }
        public virtual DbSet<McGM> McGM { get; set; }
        public virtual DbSet<McM> McM { get; set; }
        public virtual DbSet<McP> McP { get; set; }
        public virtual DbSet<MDAcc> MDAcc { get; set; }
        public virtual DbSet<MDAccType> MDAccType { get; set; }
        public virtual DbSet<MDBank> MDBank { get; set; }
        public virtual DbSet<MDBankBookType> MDBankBookType { get; set; }
        public virtual DbSet<MDBankBrch> MDBankBrch { get; set; }
        public virtual DbSet<MDBillGroup> MDBillGroup { get; set; }
        public virtual DbSet<MDBranch> MDBranch { get; set; }
        public virtual DbSet<MDBusiType> MDBusiType { get; set; }
        public virtual DbSet<MDChannel> MDChannel { get; set; }
        public virtual DbSet<MDCNRemarkType> MDCNRemarkType { get; set; }
        public virtual DbSet<MDCostCode> MDCostCode { get; set; }
        public virtual DbSet<MDCQPicture> MDCQPicture { get; set; }
        public virtual DbSet<MDCreditDeptCus> MDCreditDeptCus { get; set; }
        public virtual DbSet<MDCreditDeptCusGroup> MDCreditDeptCusGroup { get; set; }
        public virtual DbSet<MDCreditDeptHD> MDCreditDeptHD { get; set; }
        public virtual DbSet<MDCusContact> MDCusContact { get; set; }
        public virtual DbSet<MDCusMedia> MDCusMedia { get; set; }
        public virtual DbSet<MDCusTempCreditDT> MDCusTempCreditDT { get; set; }
        public virtual DbSet<MDCusTempCreditHD> MDCusTempCreditHD { get; set; }
        public virtual DbSet<MDCusType> MDCusType { get; set; }
        public virtual DbSet<MDEmGroup> MDEmGroup { get; set; }
        public virtual DbSet<MDEmpApprovCreditCus> MDEmpApprovCreditCus { get; set; }
        public virtual DbSet<MDEmpApprovCreditCusGroup> MDEmpApprovCreditCusGroup { get; set; }
        public virtual DbSet<MDEmpApprovCreditHD> MDEmpApprovCreditHD { get; set; }
        public virtual DbSet<MDEmpApprovPOHD> MDEmpApprovPOHD { get; set; }
        public virtual DbSet<MDEmpGroup> MDEmpGroup { get; set; }
        public virtual DbSet<MDEmployee> MDEmployee { get; set; }
        public virtual DbSet<MDEmPosition> MDEmPosition { get; set; }
        public virtual DbSet<MDExpn> MDExpn { get; set; }
        public virtual DbSet<MDPayPicture> MDPayPicture { get; set; }
        public virtual DbSet<MDPosition> MDPosition { get; set; }
        public virtual DbSet<MDPriorty> MDPriorty { get; set; }
        public virtual DbSet<MDReceivePlace> MDReceivePlace { get; set; }
        public virtual DbSet<MDRun> MDRun { get; set; }
        public virtual DbSet<MDRunBrch> MDRunBrch { get; set; }
        public virtual DbSet<MDSaleArea> MDSaleArea { get; set; }
        public virtual DbSet<MDSalePeriod> MDSalePeriod { get; set; }
        public virtual DbSet<MDSupplierType> MDSupplierType { get; set; }
        public virtual DbSet<MDTransp> MDTransp { get; set; }
        public virtual DbSet<MDTranspArea> MDTranspArea { get; set; }
        public virtual DbSet<MDTransportationzone> MDTransportationzone { get; set; }
        public virtual DbSet<MDVatDes> MDVatDes { get; set; }
        public virtual DbSet<MDVATGroup> MDVATGroup { get; set; }
        public virtual DbSet<MDVatOption> MDVatOption { get; set; }
        public virtual DbSet<MODocNo> MODocNo { get; set; }
        public virtual DbSet<MoGM> MoGM { get; set; }
        public virtual DbSet<MoM> MoM { get; set; }
        public virtual DbSet<MoP> MoP { get; set; }
        public virtual DbSet<MPDocNo> MPDocNo { get; set; }
        public virtual DbSet<MpGM> MpGM { get; set; }
        public virtual DbSet<MpM> MpM { get; set; }
        public virtual DbSet<MRP_SubMenu> MRP_SubMenu { get; set; }
        public virtual DbSet<MRPGenDate> MRPGenDate { get; set; }
        public virtual DbSet<mtsdocno> mtsdocno { get; set; }
        public virtual DbSet<Paret> Paret { get; set; }
        public virtual DbSet<Pdst> Pdst { get; set; }
        public virtual DbSet<pm_adjust> pm_adjust { get; set; }
        public virtual DbSet<pm_adjustdoc> pm_adjustdoc { get; set; }
        public virtual DbSet<PM_group_machine> PM_group_machine { get; set; }
        public virtual DbSet<pm_issue> pm_issue { get; set; }
        public virtual DbSet<pm_issuedoc> pm_issuedoc { get; set; }
        public virtual DbSet<pm_menulist> pm_menulist { get; set; }
        public virtual DbSet<pm_plangroup> pm_plangroup { get; set; }
        public virtual DbSet<pm_priorityJob> pm_priorityJob { get; set; }
        public virtual DbSet<pm_req> pm_req { get; set; }
        public virtual DbSet<pm_reqdoc> pm_reqdoc { get; set; }
        public virtual DbSet<pm_ro> pm_ro { get; set; }
        public virtual DbSet<pm_rodetail> pm_rodetail { get; set; }
        public virtual DbSet<pm_statusJob> pm_statusJob { get; set; }
        public virtual DbSet<pm_wc> pm_wc { get; set; }
        public virtual DbSet<pm_wcdoc> pm_wcdoc { get; set; }
        public virtual DbSet<pm_wo> pm_wo { get; set; }
        public virtual DbSet<pm_wodoc> pm_wodoc { get; set; }
        public virtual DbSet<pm_wp> pm_wp { get; set; }
        public virtual DbSet<pm_wp_componentcost> pm_wp_componentcost { get; set; }
        public virtual DbSet<pm_wp_workinstruction> pm_wp_workinstruction { get; set; }
        public virtual DbSet<POOption> POOption { get; set; }
        public virtual DbSet<PR> PR { get; set; }
        public virtual DbSet<PRDocNo> PRDocNo { get; set; }
        public virtual DbSet<PRDocNo2> PRDocNo2 { get; set; }
        public virtual DbSet<prepdoc_pm> prepdoc_pm { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSet_detail> ProductSet_detail { get; set; }
        public virtual DbSet<ProductVersion> ProductVersion { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<RCG> RCG { get; set; }
        public virtual DbSet<RCGDocNo> RCGDocNo { get; set; }
        public virtual DbSet<RCW> RCW { get; set; }
        public virtual DbSet<RCWDocNo> RCWDocNo { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReorderEOQ> ReorderEOQ { get; set; }
        public virtual DbSet<RFG> RFG { get; set; }
        public virtual DbSet<RFGDocNo> RFGDocNo { get; set; }
        public virtual DbSet<SCC> SCC { get; set; }
        public virtual DbSet<SCCDocNo> SCCDocNo { get; set; }
        public virtual DbSet<SCG> SCG { get; set; }
        public virtual DbSet<SCGDocNo> SCGDocNo { get; set; }
        public virtual DbSet<schedualtime_pm> schedualtime_pm { get; set; }
        public virtual DbSet<Scrap> Scrap { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Setproduct> Setproduct { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }
        public virtual DbSet<SOCreditApprov> SOCreditApprov { get; set; }
        public virtual DbSet<SODocNo> SODocNo { get; set; }
        public virtual DbSet<SODT_2> SODT_2 { get; set; }
        public virtual DbSet<SOOption> SOOption { get; set; }
        public virtual DbSet<srepdoc_pm> srepdoc_pm { get; set; }
        public virtual DbSet<Stdoperate> Stdoperate { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<symptoms> symptoms { get; set; }
        public virtual DbSet<t_cost_type> t_cost_type { get; set; }
        public virtual DbSet<t_count_stock_type> t_count_stock_type { get; set; }
        public virtual DbSet<t_sale_order> t_sale_order { get; set; }
        public virtual DbSet<t_warehouse_type> t_warehouse_type { get; set; }
        public virtual DbSet<t_yesno> t_yesno { get; set; }
        public virtual DbSet<Typeproduct> Typeproduct { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<UserMenu> UserMenu { get; set; }
        public virtual DbSet<vat> vat { get; set; }
        public virtual DbSet<W1> W1 { get; set; }
        public virtual DbSet<W1DocNo> W1DocNo { get; set; }
        public virtual DbSet<W1P> W1P { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Waste> Waste { get; set; }
        public virtual DbSet<WasteDocNo> WasteDocNo { get; set; }
        public virtual DbSet<WF> WF { get; set; }
        public virtual DbSet<WFDocNo> WFDocNo { get; set; }
        public virtual DbSet<Workcenter> Workcenter { get; set; }
        public virtual DbSet<Workplan> Workplan { get; set; }
        public virtual DbSet<WP> WP { get; set; }
        public virtual DbSet<WPDocNo> WPDocNo { get; set; }
        public virtual DbSet<WT> WT { get; set; }
        public virtual DbSet<WTDocNo> WTDocNo { get; set; }
        public virtual DbSet<APSMyMenu> APSMyMenu { get; set; }
        public virtual DbSet<ASP_Permission_Menu_Users> ASP_Permission_Menu_Users { get; set; }
        public virtual DbSet<audit> audit { get; set; }
        public virtual DbSet<EOQ_warehouse> EOQ_warehouse { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<FormItem> FormItem { get; set; }
        public virtual DbSet<FormName> FormName { get; set; }
        public virtual DbSet<grn> grn { get; set; }
        public virtual DbSet<grnDetail> grnDetail { get; set; }
        public virtual DbSet<Groupproduct2> Groupproduct2 { get; set; }
        public virtual DbSet<Groupproduct3> Groupproduct3 { get; set; }
        public virtual DbSet<Groupproduct4> Groupproduct4 { get; set; }
        public virtual DbSet<Groupproduct5> Groupproduct5 { get; set; }
        public virtual DbSet<Lot> Lot { get; set; }
        public virtual DbSet<Machine2> Machine2 { get; set; }
        public virtual DbSet<MCGM_Details> MCGM_Details { get; set; }
        public virtual DbSet<MCGM_RawMat> MCGM_RawMat { get; set; }
        public virtual DbSet<MCM_Details> MCM_Details { get; set; }
        public virtual DbSet<MCM_RawMat> MCM_RawMat { get; set; }
        public virtual DbSet<MCP_Details> MCP_Details { get; set; }
        public virtual DbSet<MCP_RawMat> MCP_RawMat { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MOGM_RawMat> MOGM_RawMat { get; set; }
        public virtual DbSet<MOM_RawMat> MOM_RawMat { get; set; }
        public virtual DbSet<MOP_RawMat> MOP_RawMat { get; set; }
        public virtual DbSet<movement> movement { get; set; }
        public virtual DbSet<MovementTable> MovementTable { get; set; }
        public virtual DbSet<MovementTableIn> MovementTableIn { get; set; }
        public virtual DbSet<MPM_RawMat> MPM_RawMat { get; set; }
        public virtual DbSet<mrp_bookFG> mrp_bookFG { get; set; }
        public virtual DbSet<mrp_bookFG_detail> mrp_bookFG_detail { get; set; }
        public virtual DbSet<MRPGenDate_Plan> MRPGenDate_Plan { get; set; }
        public virtual DbSet<Mts> Mts { get; set; }
        public virtual DbSet<Mts_details> Mts_details { get; set; }
        public virtual DbSet<OSODocno> OSODocno { get; set; }
        public virtual DbSet<Pdst_opr> Pdst_opr { get; set; }
        public virtual DbSet<Pdst_oprOLD> Pdst_oprOLD { get; set; }
        public virtual DbSet<pm_groupline> pm_groupline { get; set; }
        public virtual DbSet<pm_issue_componentcost> pm_issue_componentcost { get; set; }
        public virtual DbSet<pm_menuItems> pm_menuItems { get; set; }
        public virtual DbSet<pm_req_ComponentCost> pm_req_ComponentCost { get; set; }
        public virtual DbSet<pm_sym_workstep> pm_sym_workstep { get; set; }
        public virtual DbSet<pm_userpermissionItems> pm_userpermissionItems { get; set; }
        public virtual DbSet<pm_wo_changemachine> pm_wo_changemachine { get; set; }
        public virtual DbSet<pm_wo_componentcost> pm_wo_componentcost { get; set; }
        public virtual DbSet<pm_wo_workinstruction> pm_wo_workinstruction { get; set; }
        public virtual DbSet<PODocno> PODocno { get; set; }
        public virtual DbSet<PowerLate> PowerLate { get; set; }
        public virtual DbSet<PR2> PR2 { get; set; }
        public virtual DbSet<RawMat> RawMat { get; set; }
        public virtual DbSet<SCC_Member> SCC_Member { get; set; }
        public virtual DbSet<SCG_Member> SCG_Member { get; set; }
        public virtual DbSet<SetProductloss> SetProductloss { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<t_purchase_order> t_purchase_order { get; set; }
        public virtual DbSet<t_purchase_order_member> t_purchase_order_member { get; set; }
        public virtual DbSet<t_sale_order_member> t_sale_order_member { get; set; }
        public virtual DbSet<TmpPdst_opr> TmpPdst_opr { get; set; }
        public virtual DbSet<TmpRawMat> TmpRawMat { get; set; }
        public virtual DbSet<TrAccconfig> TrAccconfig { get; set; }
        public virtual DbSet<TrWin_POWH> TrWin_POWH { get; set; }
        public virtual DbSet<UnitResource> UnitResource { get; set; }
        public virtual DbSet<UserName> UserName { get; set; }
        public virtual DbSet<W1_Member> W1_Member { get; set; }
        public virtual DbSet<W1P_Member> W1P_Member { get; set; }
        public virtual DbSet<W1PDocNo> W1PDocNo { get; set; }
        public virtual DbSet<Waste_Detail> Waste_Detail { get; set; }
        public virtual DbSet<WF_Member> WF_Member { get; set; }
        public virtual DbSet<WP_Member> WP_Member { get; set; }
        public virtual DbSet<WT_Member> WT_Member { get; set; }
    }
}
