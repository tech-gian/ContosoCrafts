#pragma checksum "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d67d595f5d510a88e8ddbb9ad88344a3fc1670d0"
// <auto-generated/>
#pragma warning disable 1591
namespace ContosoCrafts.Website.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
using ContosoCrafts.Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
using ContosoCrafts.Website.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 12 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-footer");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "small");
            __builder.AddAttribute(24, "class", "text-muted");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#productModal");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 23 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade");
            __builder.AddAttribute(39, "id", "productModal");
            __builder.AddAttribute(40, "tabindex", "-1");
            __builder.AddAttribute(41, "role", "dialog");
            __builder.AddAttribute(42, "aria-labelledby", "productTitle");
            __builder.AddAttribute(43, "aria-hidden", "true");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(47, "role", "document");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-content");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "modal-header");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "h5");
            __builder.AddAttribute(56, "class", "modal-title");
            __builder.AddAttribute(57, "id", "productTitle");
            __builder.AddContent(58, 
#nullable restore
#line 34 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-body");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "card");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "card-img");
            __builder.AddAttribute(70, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "card-body");
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "class", "card-text");
            __builder.AddContent(78, 
#nullable restore
#line 44 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "modal-footer");
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 49 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                     if (voteCount == 0) { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                        ");
            __builder.AddMarkupContent(87, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 51 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                    }
                    else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                        ");
            __builder.OpenElement(89, "span");
            __builder.AddContent(90, 
#nullable restore
#line 53 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, " ");
            __builder.AddContent(92, 
#nullable restore
#line 53 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 54 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 56 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                     for (int i=0; i<5; ++i) {
                        var currentStar = i;
                        if (i <= currentRating) { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa fa-star checked");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 60 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                        }
                        else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa fa-star");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 63 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 69 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\zapan\Source\Repos\ContosoCrafts\ContosoCrafts.Website\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating() {
        if (selectedProduct.Ratings == null) {
            currentRating = 0;
            voteCount = 0;
        }
        else {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating) {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
