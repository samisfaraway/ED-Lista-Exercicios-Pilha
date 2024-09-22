public class No
{
    public Documento documento;
    public No prox;

    public No(Documento doc)
    {
        this.documento = doc;
        this.prox = null;
    }

    public void imprimir()
    {
        documento.Imprimir();
    }
}
