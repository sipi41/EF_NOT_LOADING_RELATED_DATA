using FluentValidation;
using ITT_OneTeam.Models.FACT;
using System.ComponentModel.DataAnnotations;

namespace ITT_OneTeam.ViewModels
{
    public class SaveView
    {
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a Name for this view")]
        //[Display(Name = "My Name")]
        public string? ViewName { get; set; }

        public List<ViewStateEntry> StateEntries { get; set; } = new();

    }

    public class SaveViewValidator : AbstractValidator<SaveView>
    {
        public SaveViewValidator()
        {
            RuleFor(SaveView => SaveView.ViewName)
                .NotEmpty()
                .WithMessage("Please enter the Name to be used.");
            RuleFor(sv => sv.ViewName)
                .Must((sv, m) => sv.StateEntries.Any(a => a.FriendlyName.Equals(m, StringComparison.CurrentCultureIgnoreCase)) == false)
                .WithMessage("Please enter another name, such name already exist.");
            
        }
    }


}
