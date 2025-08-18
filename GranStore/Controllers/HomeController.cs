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
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Mouse"},
            new Categoria { Id = 2, Nome = "Mousepad"}
        };

        List<Produto> produtos = new List<Produto>
        {
            new Produto {
            Id = 1,
            Categoria = categorias[1],
            Nome = "Pulsar ZywOo",
            Descricao = "Desenvolvido em colaboração com o astro do CS:GO, ZywOo, o Pulsar ZywOo The Chosen é um mouse gamer de elite que une velocidade, precisão e conforto para jogadores que não aceitam nada menos do que performance máxima.",
            ValorCusto = 1649.90m,
            ValorVenda = 1484.90m,
            QtdeEstoque = 26,
            Foto = "/img/Produtos/pulsar-zywoo-medium-white.jpg",
        },
            new Produto {
            Id = 2,
            Categoria = categorias[1],
            Nome = "Finalmouse ULX Prophecy Small",
            Descricao = "Comemorando 10 anos de inovação revolucionária, o ULX Prophecy da Finalmouse redefine os padrões de desempenho nos eSports. Com peso entre apenas 33 e 38 gramas, este mouse foi projetado para transformar sua experiência de jogo.",
            ValorCusto = 2199.90m,
            ValorVenda = 1979.91m,
            QtdeEstoque = 43,
            Foto = "/img/Produtos/Finalmouse ULX Prophecy Small.jpg"
        },
            new Produto {
            Id = 3,
            Categoria = categorias[1],
            Nome = "Viper V3 PRO",
            Descricao = "Experimente um desempenho incomparável no calor da batalha com o mouse sem fio Razer Viper V3 Pro – o predador de ponta entre os mouses sem fio para esportes eletrônicos. Projetado para dominar, o Viper V3 Pro combina leveza com tecnologia de ponta para proporcionar a melhor experiência de jogo competitiva. O Razer HyperPolling Wireless Dongle, já incluso, permite uma taxa de polling de até 8k com seu Viper V3 Pro.",
            ValorCusto = 1899.90m,
            ValorVenda = 1709.91m,
            QtdeEstoque = 29,
            Foto = "/img/Produtos/ViperV3PRO.jpg"
        },
            new Produto {
            Id = 4,
            Categoria = categorias[1],
            Nome = "Endgame Gear OP1w 4K v2",
            Descricao = "O Endgame Gear OP1w 4K V2 foi projetado para entregar resposta ultrarrápida, construção robusta e controle preciso, atendendo tanto jogadores casuais quanto profissionais. Com conexão wireless de alta performance e taxa de polling de 4000 Hz, cada movimento é registrado com latência mínima, garantindo vantagem competitiva em qualquer partida.",
            ValorCusto = 1099.90m,
            ValorVenda = 989.91m,
            QtdeEstoque = 14,
            Foto = "/img/Produtos/Endgame Gear OP1w 4K v2.jpg"
        },
          new Produto {
            Id = 5,
            Categoria = categorias[2],
            Nome = "KanamiMinamiGlasspad",
            Descricao = "Descubra a fusão ideal entre estética e funcionalidade com o Mousepad de Vidro Minami / Edição Limitada, uma verdadeira obra-prima produzida pela Kanami e Arbiter Studio, com ilustração exclusiva de 58. Mais do que um simples acessório, este mousepad transforma sua experiência digital ao unir arte e tecnologia em um único produto excepcional.",
            ValorCusto = 1499.90m,
            ValorVenda = 1349.91m,
            QtdeEstoque = 21,
            Foto = "/img/Produtos/KanamiMinamiGlasspad.jpg"
        },
          new Produto {
            Id = 6,
            Categoria = categorias[2],
            Nome = "Wallhack SP-004",
            Descricao = "Projetado na Dinamarca. Nossos produtos são projetados e testados internamente, permitindo uma interação constante dentro da nossa equipe, composta por jogadores ex-profissionais de alto nível, diretamente em nossa sede. A superfície do SP-004 foi desenvolvida para apresentar um baixo coeficiente de atrito estático e cinético, resultando em uma superfície ultra suave que oferece rastreamento praticamente sem atrito. Fabricado com vidro de silicato aquecido a 620°C, o SP-004 possui uma estrutura de material comparável ao vidro de segurança, garantindo uma robustez que resiste ao desgaste diário com facilidade. A base de silicone 60A proporciona uma combinação única de flexibilidade, adaptando-se a diferentes formatos de mesa, enquanto oferece excelente aderência para sessões de jogo sem distrações.",
            ValorCusto = 1299.90m,
            ValorVenda = 1079.91m,
            QtdeEstoque = 23,
            Foto = "/img/Produtos/Wallhack SP-004.jpg"
        },
          new Produto {
            Id = 7,
            Categoria = categorias[2],
            Nome = "LGG x Pulsar Hyperion XXL",
            Descricao = "Desenvolvido para oferecer um desempenho impecável, o LGG x Pulsar Hyperion conta com uma superfície de tecido de alta qualidade, projetada no Japão e refinada por meio de testes extensivos. O resultado é um equilíbrio perfeito entre deslizamento controlado e velocidade média, garantindo movimentos rápidos, precisos e um poder de parada excepcional. Com uma textura leve e uma superfície quase lisa, o Hyperion proporciona precisão absoluta nos momentos decisivos. Sua base SlimFlex (antiga PORON) oferece estabilidade e conforto, enquanto as bordas costuradas reforçam a durabilidade, prevenindo desgastes e desfiamentos. Criado para jogadores exigentes, o Hyperion está disponível em duas opções de base personalizáveis – Soft e Xsoft SlimFlex –, permitindo que você escolha o nível ideal de amortecimento e flexibilidade para seu estilo de jogo.",
            ValorCusto = 1199.90m,
            ValorVenda = 944.91m,
            QtdeEstoque = 22,
            Foto = "/img/Produtos/LGGxPulsarHyperionXXL.jpg"
        },
          new Produto {
            Id = 8,
            Categoria = categorias[2],
            Nome = "Artisan FX Key-83 XL",
            Descricao = "A Artisan é uma conhecida e renomada fabricante de mouse pads. Ao longo dos anos, a empresa construiu uma reputação invejável e consequentemente muita procura por seus produtos. Os Mouse Pads são produzidos no Japão, utilizando materiais e equipamentos da mais alta qualidade. O processo de fabricação é complexo e o controle de qualidade é extremamente rígido, o que resulta em mouse pads incríveis, resistentes e com um feel inigualável. O Mouse PadKey-83 apresenta uma superfície de design inovador com padrão de onda hexagonal exclusivo, desenvolvido para reduzir significativamente o atrito em movimentos diagonais e laterais. Essa tecnologia proporciona maior estabilidade e suavidade durante o uso, aprimorando a experiência do usuário. Ideal para jogos de alta intensidade, o deslizamento otimizado do Key-83 eleva o desempenho e torna a experiência de jogo mais imersiva e envolvente.",
            ValorCusto = 749.90m,
            ValorVenda = 674.91m,
            QtdeEstoque = 9,
            Foto = "/img/Produtos/ArtisanFXKey-83XL.jpg"
        },

    };

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
