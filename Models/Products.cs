using System.ComponentModel.DataAnnotations;
namespace cepedi.Models;

public class Products {
    public int Id { get; set; }
    
    [Required]
    [StringLength(100, ErrorMessage = "Nome não pode passar de 100 caracteres.")]
    public string Name { get; set; }
    
    [Url(ErrorMessage = "PathImage tem que ser uma URL válida.")]    
    public string PathImage { get; set; }
    
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "O preço deve ser um valor positivo.")]    
    public decimal Price { get; set; }
    
    [StringLength(250, ErrorMessage = "Base description cannot exceed 250 characters.")]
    public string BaseDescription { get; set; }
    
    public string FullDescription { get; set; }
    
    public int CategoryId { get; set; }
}