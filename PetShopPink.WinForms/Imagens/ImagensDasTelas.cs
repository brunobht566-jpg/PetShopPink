namespace PetShopPink.WinForms.Imagens;

internal static class ImagensDasTelas
{
    public static void Aplicar(Form tela, string nomeArquivo)
    {
        string caminho = Path.Combine(AppContext.BaseDirectory, "Imagens", nomeArquivo);
        if (!File.Exists(caminho)) return;

        tela.BackgroundImage = Image.FromFile(caminho);
        // Stretch ocupa toda a janela, mesmo que a proporção da imagem seja alterada.
        tela.BackgroundImageLayout = ImageLayout.Stretch;
    }
}
