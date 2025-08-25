using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = new()
        {
            new Categoria { Id = 1, Nome = "Skins" }
        };

        List<Produto> produtos = new List<Produto>
        {
            new Produto {
                Id = 1,
                Categoria = categorias[0],
                Nome = "AWP | Dragon Lore (Factory New)",
                Descricao = "A lendária skin da AWP com status FN, extremamente rara.",
                ValorCusto = 150000.00m,
                ValorVenda = 135000.00m,
                QtdeEstoque = 2,
                Foto = "/img/Skins/awp-dragon-lore-fn.jpg"
            },
            new Produto {
                Id = 2,
                Categoria = categorias[0],
                Nome = "Karambit | Case Hardened (Blue Gem)",
                Descricao = "Karambit com pattern blue gem raro.",
                ValorCusto = 180000.00m,
                ValorVenda = 165000.00m,
                QtdeEstoque = 1,
                Foto = "/img/Skins/karambit-case-hardened-bluegem.jpg"
            },
            new Produto {
                Id = 3,
                Categoria = categorias[0],
                Nome = "AK-47 | Wild Lotus (Factory New)",
                Descricao = "Skin floral rara e desejada da AK-47.",
                ValorCusto = 60000.00m,
                ValorVenda = 54000.00m,
                QtdeEstoque = 3,
                Foto = "/img/Skins/ak47-wild-lotus.jpg"
            },
            new Produto {
                Id = 4,
                Categoria = categorias[0],
                Nome = "M4A4 | Howl (Factory New)",
                Descricao = "Skin contrabandeada e exclusiva da M4A4.",
                ValorCusto = 45000.00m,
                ValorVenda = 41000.00m,
                QtdeEstoque = 2,
                Foto = "/img/Skins/m4a4-howl.jpg"
            },
            new Produto {
                Id = 5,
                Categoria = categorias[0],
                Nome = "Butterfly Knife | Crimson Web (Factory New)",
                Descricao = "Faca extremamente rara com web pattern ideal.",
                ValorCusto = 90000.00m,
                ValorVenda = 84999.00m,
                QtdeEstoque = 1,
                Foto = "/img/Skins/butterfly-crimson-web.jpg"
            },
            new Produto {
                Id = 6,
                Categoria = categorias[0],
                Nome = "Souvenir AWP | Medusa (FN)",
                Descricao = "Skin souvenir da AWP Medusa com adesivos de torneios.",
                ValorCusto = 120000.00m,
                ValorVenda = 112000.00m,
                QtdeEstoque = 1,
                Foto = "/img/Skins/awp-medusa-souvenir.jpg"
            },
            new Produto {
                Id = 7,
                Categoria = categorias[0],
                Nome = "StatTrak™ M9 Bayonet | Doppler (Sapphire)",
                Descricao = "Faca Doppler Sapphire com StatTrak™.",
                ValorCusto = 85000.00m,
                ValorVenda = 79999.00m,
                QtdeEstoque = 2,
                Foto = "/img/Skins/m9-doppler-sapphire.jpg"
            },
            new Produto {
                Id = 8,
                Categoria = categorias[0],
                Nome = "Desert Eagle | Blaze (FN)",
                Descricao = "Skin clássica e popular da Deagle.",
                ValorCusto = 20000.00m,
                ValorVenda = 18999.00m,
                QtdeEstoque = 5,
                Foto = "/img/Skins/deagle-blaze.jpg"
            }
        };

        // Aqui você pode passar os produtos para a view, se desejar.
        // Exemplo: return View(produtos);
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
