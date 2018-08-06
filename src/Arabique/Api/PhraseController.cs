using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Arabique.Api
{
    [ApiController, Route("api/phrases")]
    public class PhraseController : Controller
    {
        private readonly HashSet<Phrase> _phrases = new HashSet<Phrase>
        {
            new Phrase("The girl drinks", "البِنْتُ تَشرَبُ"),
            new Phrase("The boy drinks", "الوَلَدُ يَشرَبُ"),
            new Phrase("The woman drinks", "المَرْأة تَشرَبُ"),
            new Phrase("The man drinks", "الرَّجُلُ يَشرَبُ"),
            new Phrase("She drinks", "هِيَ تَشرَبُ"),
            new Phrase("He drinks", "هُوَ يَشرَبُ"),

            new Phrase("The girl eats", "البِنْتُ تَأكُلُ"),
            new Phrase("The boy eats", "الوَلَدُ يَأكُلُ"),
            new Phrase("The woman eats", "المَرْأة تَأكُلُ"),
            new Phrase("The man eats", "الرَّجُلُ يَأكُلُ"),
            new Phrase("She eats", "هِيَ تَأكُلُ"),
            new Phrase("He eats", "هُوَ يَأكُلُ"),
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
