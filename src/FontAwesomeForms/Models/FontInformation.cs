using System;
using System.Collections.Generic;

namespace FontAwesomeForms.Models
{
    public class FontInformation
    {
        public string FontName { get; set; }

        public string FontDisplayName { get; set; }

        public string Icon1 { get; set; }

        public string Icon2 { get; set; }

        public string Icon3 { get; set; }

        public string Icon4 { get; set; }

        public static List<FontInformation> FontAwesomeFree()
        {
            var fonts = new List<FontInformation>();

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomeFree.Solid,
                FontDisplayName = "Font Awesome Free Solid",
                Icon1 = "\uf274",
                Icon2 = "\uf279",
                Icon3 = "\uf2d0",
                Icon4 = "\uf186"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomeFree.Regular,
                FontDisplayName = "Font Awesome Free Regular",
                Icon1 = "\uf274",
                Icon2 = "\uf279",
                Icon3 = "\uf2d0",
                Icon4 = "\uf186"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomeFree.Brands,
                FontDisplayName = "Font Awesome Free Brands",
                Icon1 = "\uf09b",
                Icon2 = "\uf370",
                Icon3 = "\uf179",
                Icon4 = "\uf17b"
            });

            return fonts;
        }

        public static List<FontInformation> FontAwesomePro()
        {
            var fonts = new List<FontInformation>();

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomePro.Solid,
                FontDisplayName = "Font Awesome Pro Solid",
                Icon1 = "\uf74b",
                Icon2 = "\ue022",
                Icon3 = "\uf7b2",
                Icon4 = "\uf0fb"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomePro.Regular,
                FontDisplayName = "Font Awesome Pro Regular",
                Icon1 = "\uf74b",
                Icon2 = "\ue022",
                Icon3 = "\uf7b2",
                Icon4 = "\uf0fb"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomePro.Light,
                FontDisplayName = "Font Awesome Pro Light",
                Icon1 = "\uf74b",
                Icon2 = "\ue022",
                Icon3 = "\uf7b2",
                Icon4 = "\uf0fb"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomePro.DuoTone,
                FontDisplayName = "Font Awesome Pro DuoTone",
                Icon1 = "\uf047",
                Icon2 = "\uf7e5",
                Icon3 = "\uf77e",
                Icon4 = "\uf6b8"
            });

            fonts.Add(new FontInformation()
            {
                FontName = FontConstants.FontAwesomePro.Brands,
                FontDisplayName = "Font Awesome Pro Brands",
                Icon1 = "\uf370",
                Icon2 = "\uf1d3",
                Icon3 = "\uf0e1",
                Icon4 = "\uf3a6"
            });

            return fonts;
        }
    }
}
