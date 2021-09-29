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
    public class IndexModel : PageModel
    {
        private readonly PersonalContext _context;

        public IndexModel(PersonalContext context)
        {
            _context = context;
        }

        public IList<PersonalInformation> PersonalInformation { get;set; }

        public async Task OnGetAsync()
        {
            PersonalInformation = await _context.PersonalInformation.ToListAsync();
        }
    }
}
