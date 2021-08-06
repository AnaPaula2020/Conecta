using System;
using System.Threading;
using ValTestAT.Base;
using ValTestAT.Config;
using ValTestAT.Tools;

namespace ValTestAT
{
	partial class ProdutoPage : BasePage
	{
		public void AcessarProduto(string url)
		{
			NavigateTo(BaseUrl + url);
			CheckForURL(BaseUrl + url);
		}
       
        public void VerificarProduto(string produto)
        {
            CheckForURL(BaseUrl + produto);
        }
               
    }
}