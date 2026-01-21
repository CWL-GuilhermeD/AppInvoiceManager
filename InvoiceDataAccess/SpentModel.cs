using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace InvoiceDataAccess.Configuration
{
    [Index(nameof(Status))]
    [Table("Spents")]
    public class SpentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [NotNull]
        [DisplayName("Loja")]
        public string SpentName { get; set; } = "Sem nome";

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Valor não pode ser negativo.")]
        [NotNull]
        [DisplayName("Valor")]
        public double SpentValue { get; set; } = 0.0;

        [Required]
        [NotNull]
        [Range(1, 500)]
        [DisplayName("Parcela Atual")]
        public int InitialParcel { get; set; } = 1;

        [Required]
        [NotNull]
        [Range(1, 500)]
        [DisplayName("Parcela Final")]
        public int FinalParcel { get; set; } = 1;

        [NotNull]
        [Required]
        [DisplayName("Nome do Pagador")]
        public string NameClient { get; set; } = "Sem nome";

        [StringLength(20)]
        public string Status { get; set; } = "ATIVO";

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
