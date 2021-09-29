using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Personal.Models;

namespace personal.Pages_PersonalInformation
{
    public class DeleteModel : PageModel
    {
        private readonly PersonalContext _context;

        public DeleteModel(PersonalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PersonalInformation PersonalInformation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonalInformation = await _context.PersonalInformation.FirstOrDefaultAsync(m => m.ID == id);

            if (PersonalInformation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PersonalInformation = await _context.PersonalInformation.FindAsync(id);

            if (PersonalInformation != null)
            {
                _context.PersonalInformation.Remove(PersonalInformation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
