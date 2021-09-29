using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Personal.Models;

namespace personal.Pages_PersonalInformation
{
    public class CreateModel : PageModel
    {
        private readonly PersonalContext _context;

        public CreateModel(PersonalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PersonalInformation PersonalInformation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PersonalInformation.Add(PersonalInformation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
