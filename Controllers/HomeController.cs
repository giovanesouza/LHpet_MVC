using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instâncias cliente
        Cliente c1 = new Cliente(01, "Josefino Fonseca Arruda", "987.342.789-07", "josefinoarruda@gmail.com", "Thor");
        Cliente c2 = new Cliente(02, "Amanda Rafaela Oliveira", "789.987.302-13", "amandaoliveira@gmail.com", "Amora");
        Cliente c3 = new Cliente(03, "Fernanda Farias da Silva", "345.789.382-25", "fernandasilva@gmail.com", "Jujuba");
        Cliente c4 = new Cliente(03, "Thiago Henrique Figueiredo", "569.756.324-67", "thfigueiredo@gmail.com", "Pit");
        Cliente c5 = new Cliente(03, "João José de Deus", "345.689.023-36", "joao@gmail.com", "Chocolate");

        // Lista de clientes (Para ser visualizada no Front)
        List<Cliente> listaClientes = new List<Cliente>();
        
        // Adiciona itens na lista de clientes
        listaClientes.Add(c1);
        listaClientes.Add(c2);
        listaClientes.Add(c3);
        listaClientes.Add(c4);
        listaClientes.Add(c5);

        ViewBag.listaClientes = listaClientes; // Deixa a lista disponível para ser utilizada na view

        // Instâncias Fornecedor
        Fornecedor f1 = new Fornecedor(01, "C# PET S/A", "32.321.102/0001-80", "csharp@pet.org");
        Fornecedor f2 = new Fornecedor(02, "Dog alt", "12.321.120/0012-32", "dog_alt@dogalt.com.br");
        Fornecedor f3 = new Fornecedor(03, "My pet", "15.789.102/0001-63", "mypet@mypet.com");
        Fornecedor f4 = new Fornecedor(04, "PetNutri", "32.321.102/0001-80", "petnutri@petnutri.com.br");
        Fornecedor f5 = new Fornecedor(05, "MaxPet", "65.312.543/0008-15", "maxpet@maxpet.com.br");

        // Lista de fornecedores (Para ser visualizada no Front)
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        // Adiciona itens na lista de fornecedores
        listaFornecedores.Add(f1);
        listaFornecedores.Add(f2);
        listaFornecedores.Add(f3);
        listaFornecedores.Add(f4);
        listaFornecedores.Add(f5);

        ViewBag.listaFornecedores = listaFornecedores; // Deixa a lista disponível para ser utilizada na view

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
