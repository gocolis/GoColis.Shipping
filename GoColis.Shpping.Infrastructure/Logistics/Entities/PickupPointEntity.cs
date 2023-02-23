using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoColis.Shpping.Infrastructure.Logistics.Entities;

    internal class PickupPointEntity
    {
        public class PointDeCollecte
        {
            [Key]
            [StringLength(20)]
            public string Id { get; set; }

            [Required]
            [StringLength(200)]
            public string Adresse { get; set; }

            [Required]
            [StringLength(50)]
            public string Ville { get; set; }

            [Required]
            [StringLength(10)]
            public string CodePostal { get; set; }

            [Required]
            [StringLength(50)]
            public string Pays { get; set; }

            [Required]
            [Column(TypeName = "decimal(10, 8)")]
            public decimal Latitude { get; set; }

            [Required]
            [Column(TypeName = "decimal(11, 8)")]
            public decimal Longitude { get; set; }

            public ICollection<HoraireOuverture> HorairesOuverture { get; set; }

            public ICollection<PlanningAnnuel> PlanningsAnnuel { get; set; }
        }

        public class HoraireOuverture
        {
            [Key]
            public int ID { get; set; }

            [Required]
            [StringLength(10)]
            public string Jour { get; set; }

            [Required]
            public TimeSpan Ouverture { get; set; }

            [Required]
            public TimeSpan Fermeture { get; set; }

            [Required]
            [ForeignKey("PointDeCollecte")]
            [StringLength(20)]
            public string PointDeCollecteID { get; set; }

            public PointDeCollecte PointDeCollecte { get; set; }
        }

        public class PlanningAnnuel
        {
            [Key]
            public int ID { get; set; }

            [Required]
            [ForeignKey("PointDeCollecte")]
            [StringLength(20)]
            public string PointDeCollecteID { get; set; }

            public PointDeCollecte PointDeCollecte { get; set; }

            [Required]
            [StringLength(10)]
            public string Periode { get; set; }

            [Required]
            public DateTime Debut { get; set; }

            [Required]
            public DateTime Fin { get; set; }
        }
    }
}
