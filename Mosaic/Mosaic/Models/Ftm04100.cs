namespace Mosaic.Models.Ftm04100;

using Dapper.Contrib.Extensions;

[Table("Ftm04100")]
public class Ftm04100
{
    [Key]
    public int CdClifor { get; set; }
    public required string CdProduto { get; set; }
    public int QtdAcessos { get; set; }
}
