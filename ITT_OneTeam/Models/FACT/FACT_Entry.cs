using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ITT_OneTeam.Models.FACT;

/*[Keyless, NotMapped]*/

[Table("FACT_TOOLS")]
public class FACT_Entry
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid tool_guid { get; set; }

    public virtual List<FactComment> comments { get; set; } = new();

    // ---------------------------- FROZEN COLUMNS

    [Display(Name = "Tool Name")]
    public string tool_name { get; set; }

    [Display(Name = "Tool Move-in")]
    [Column(TypeName = "date")]
    public DateTime? tool_move_in_date { get; set; }
    [Display(Name = "FA Sort")] 
    public int? fa_sort { get; set; }
    [Display(Name = "First Pre-HU")]
    public int? first_pre_hu { get; set; }
    [Display(Name = "ITT FA PM")]
    public string? itt_fa_pm { get; set; }
    [Display(Name = "Location")]
    public string? location { get; set; }
    [Display(Name = "Phase")]
    public string phase { get; set; }
    [Display(Name = "Floor")]
    public string? floor { get; set; }
    [Display(Name = "Mod Vs. Non-Mod")]
    public string? mod_vs_nonmod { get; set; }
    [Display(Name = "Functional Area")]
    public string functional_area { get; set; }
    [Display(Name = "Pre-HU Finish Total Float")]
    public int? prehu_finish_total_float { get; set; }

    // ---------------------------- REGULAR COLUMNS

    [Display(Name = "Scope")]
    public string scope { get; set; }
    [Display(Name = "Event Type")]
    public string? event_type { get; set; }

    [Column("3D Stage 2 Finish", TypeName = "date"), Display(Name = "3D Stage 2 Finish")]
    public DateTime? _3D_Stage_2_Finish { get; set; }

    [Column("3D Stage 2 Finish Actual", TypeName = "date"), Display(Name = "3D Stage 2 Finish Actual")]
    public DateTime? _3D_Stage_2_Finish_Actual { get; set; }

    [Column("2D Layout Finish Actual", TypeName = "date"), Display(Name = "2D Layout Finish Actual")]
    public DateTime? _2D_Layout_Finish_Actual { get; set; }

    [Column("2D Layout Finish", TypeName = "date"), Display(Name = "2D Layout Finish")]
    public DateTime? _2D_Layout_Finish { get; set; }

    //---------------------------- NEW COLUMNS

    [Column("Datum Finish")]
    public string Datum_Finish { get; set; }

    [Column("Datum Finish Actual")]
    public string Datum_Finish_Actual { get; set; }

    [Column("Core Drill Finish")]
    public string Core_Drill_Finish { get; set; }

    [Column("Core Drill Finish Actual")]
    public string Core_Drill_Finish_Actual { get; set; }

    [Column("BOM Finish", TypeName = "date")]
    public DateTime? BOM_Finish { get; set; }

    [Column("BOM Finish Actual", TypeName = "date")]
    public DateTime? BOM_Finish_Actual { get; set; }

    [Column("Design Start", TypeName = "date")]
    public DateTime? Design_Start { get; set; }

    [Column("Design Start Actual", TypeName = "date")]
    public DateTime? Design_Start_Actual { get; set; }

    [Column("IFC Finish", TypeName = "date")]
    public DateTime? IFC_Finish { get; set; }

    [Column("IFC Finish Actual", TypeName = "date")]
    public DateTime? IFC_Finish_Actual { get; set; }

    [Column("PHU Survey Finish", TypeName = "date")]
    public DateTime? PHU_Survey_Finish { get; set; }

    [Column("PHU Survey Finish Actual", TypeName = "date")]
    public DateTime? PHU_Survey_Finish_Actual { get; set; }

    [Column("Foundation Set Start", TypeName = "date")]
    public DateTime? Foundation_Set_Start { get; set; }

    [Column("Foundation Set Start Actual", TypeName = "date")]
    public DateTime? Foundation_Set_Start_Actual { get; set; }

    [Column("Foundation Set Finish", TypeName = "date")]
    public DateTime? Foundation_Set_Finish { get; set; }

    [Column("Foundation Set Finish Actual", TypeName = "date")]
    public DateTime? Foundation_Set_Finish_Actual { get; set; }

    [Column("Material DD Finish", TypeName = "date")]
    public DateTime? Material_DD_Finish { get; set; }

    [Column("Material DD Finish Actual", TypeName = "date")]
    public DateTime? Material_DD_Finish_Actual { get; set; }

    [Column("Pre Hookup Start", TypeName = "date")]
    public DateTime? Pre_Hookup_Start { get; set; }

    [Column("Pre Hookup Start Actual", TypeName = "date")]
    public DateTime? Pre_Hookup_Start_Actual { get; set; }

    [Column("Pre Hookup Finish", TypeName = "date")]
    public DateTime? Pre_Hookup_Finish { get; set; }

    [Column("Pre Hookup Finish Actual", TypeName = "date")]
    public DateTime? Pre_Hookup_Finish_Actual { get; set; }

    [Column("Move-InStart", TypeName = "date")]
    public DateTime? Move_InStart { get; set; }

    [Column("Move-InStart Actual", TypeName = "date")]
    public DateTime? Move_InStart_Actual { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DockingStart { get; set; }

    [Column("DockingStart Actual", TypeName = "date")]
    public DateTime? DockingStart_Actual { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DockingFinish { get; set; }

    [Column("DockingFinish Actual", TypeName = "date")]
    public DateTime? DockingFinish_Actual { get; set; }

    [Column("HU Survey WalkFinish", TypeName = "date")]
    public DateTime? HU_Survey_WalkFinish { get; set; }

    [Column("HU Survey WalkFinish Actual", TypeName = "date")]
    public DateTime? HU_Survey_WalkFinish_Actual { get; set; }

    [Column("T0 Hookup Start", TypeName = "date")]
    public DateTime? T0_Hookup_Start { get; set; }

    [Column("T0 Hookup Start Actual", TypeName = "date")]
    public DateTime? T0_Hookup_Start_Actual { get; set; }

    [Column("T0 Hookup Finish", TypeName = "date")]
    public DateTime? T0_Hookup_Finish { get; set; }

    [Column("T0 Hookup Finish Actual", TypeName = "date")]
    public DateTime? T0_Hookup_Finish_Actual { get; set; }

    [Column("T0 T/S Start", TypeName = "date")]
    public DateTime? T0_T_S_Start { get; set; }

    [Column("T0 T/S Start Actual", TypeName = "date")]
    public DateTime? T0_T_S_Start_Actual { get; set; }

    [Column("T0 T/S Finish", TypeName = "date")]
    public DateTime? T0_T_S_Finish { get; set; }

    [Column("T0 T/S Finish Actual", TypeName = "date")]
    public DateTime? T0_T_S_Finish_Actual { get; set; }

    [Column("T0 UTO Start", TypeName = "date")]
    public DateTime? T0_UTO_Start { get; set; }

    [Column("T0 UTO Start Actual", TypeName = "date")]
    public DateTime? T0_UTO_Start_Actual { get; set; }

    [Column("T0 UTO Finish", TypeName = "date")]
    public DateTime? T0_UTO_Finish { get; set; }

    [Column("T0 UTO Finish Actual", TypeName = "date")]
    public DateTime? T0_UTO_Finish_Actual { get; set; }

    [Column("T1 Hookup Start", TypeName = "date")]
    public DateTime? T1_Hookup_Start { get; set; }

    [Column("T1 Hookup Start Actual", TypeName = "date")]
    public DateTime? T1_Hookup_Start_Actual { get; set; }

    [Column("T1 Hookup Finish", TypeName = "date")]
    public DateTime? T1_Hookup_Finish { get; set; }

    [Column("T1 Hookup Finish Actual", TypeName = "date")]
    public DateTime? T1_Hookup_Finish_Actual { get; set; }

    [Column("T1 T/S Start", TypeName = "date")]
    public DateTime? T1_T_S_Start { get; set; }

    [Column("T1 T/S Start Actual", TypeName = "date")]
    public DateTime? T1_T_S_Start_Actual { get; set; }

    [Column("T1 T/S Finish", TypeName = "date")]
    public DateTime? T1_T_S_Finish { get; set; }

    [Column("T1 T/S Finish Actual", TypeName = "date")]
    public DateTime? T1_T_S_Finish_Actual { get; set; }

    [Column("T1 UTO Start", TypeName = "date")]
    public DateTime? T1_UTO_Start { get; set; }

    [Column("T1 UTO Start Actual", TypeName = "date")]
    public DateTime? T1_UTO_Start_Actual { get; set; }

    [Column("T1 UTO Finish", TypeName = "date")]
    public DateTime? T1_UTO_Finish { get; set; }

    [Column("T1 UTO Finish Actual", TypeName = "date")]
    public DateTime? T1_UTO_Finish_Actual { get; set; }


}
