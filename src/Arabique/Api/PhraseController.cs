using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arabique.Api
{
    [ApiController, Route("api/phrases")]
    public class PhraseController : Controller
    {
        private readonly HashSet<Phrase> _phrases = new HashSet<Phrase>
        {
            new Phrase("The girl is drinking", "البِنْتُ تَثْرَبُ"),
            new Phrase("The boy is drinking", "الوَلَدُ يَتَثْرَبُ"),
        };

        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            var phrases = _phrases
                .OrderBy(i => Guid.NewGuid())
                .Select(PhraseTest.Create);

            return Ok(phrases);
        }
    }
}
