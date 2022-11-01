import { Component, ChangeDetectorRef, ElementRef, Output, Renderer2, ViewEncapsulation, ViewChild, TemplateRef} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { PageComponent} from "@mobilize/webforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "e-shop-legacy-web-forms-log-in-page",
   styleUrls : ["./log-in-page.component.css","./../../../../assets/css/bootstrap.css","./../../../../assets/css/base.css","./../../../../assets/css/custom.css","./../../../../assets/css/site.css"],
   templateUrl : "./log-in-page.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["frmeShopLegacyWebFormsLogIn"])
export class LogInPageComponent extends PageComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}