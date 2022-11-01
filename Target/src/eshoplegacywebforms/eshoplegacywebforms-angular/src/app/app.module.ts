import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NgZone, ChangeDetectorRef} from '@angular/core';
import { AppComponent } from './app.component';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';
import { WebFormsModule } from '@mobilize/webforms-components';
import { AjaxModule } from '@mobilize/webforms-components';
import { EShopLegacyWebFormsModule } from './e-shop-legacy-web-forms.module';
import { BaseValidatorService } from '@mobilize/winforms-components';
import { WebFormsBaseValidatorService } from '@mobilize/webforms-components';
import { InternalEventHandlerService } from '@mobilize/webforms-components';
@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
    EShopLegacyWebFormsModule,
    WebFormsModule,
    AjaxModule,
  ],
  providers: [WebMapService, {provide: BaseValidatorService, useExisting: WebFormsBaseValidatorService}, InternalEventHandlerService  ],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }

