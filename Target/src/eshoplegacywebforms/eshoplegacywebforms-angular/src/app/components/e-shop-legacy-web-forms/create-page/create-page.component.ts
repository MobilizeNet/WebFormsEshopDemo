import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { PageComponent} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "e-shop-legacy-web-forms-catalog-create-page",
   styleUrls : ["./create-page.component.css"],
   templateUrl : "./create-page.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmeShopLegacyWebFormsCatalogCreate"])
export class CreatePageComponent extends PageComponent {
   @ViewChild('MainContent')
   MainContent : TemplateRef <any>;
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}