
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';
import { WebFormsModule } from '@mobilize/webforms-components';
import { AjaxModule } from '@mobilize/webforms-components';

import * as eShopLegacyWebForms from './components/e-shop-legacy-web-forms';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
    WebFormsModule,
    AjaxModule,
  ],
  exports: [
    eShopLegacyWebForms.CreatePageComponent,
    eShopLegacyWebForms.DeletePageComponent,
    eShopLegacyWebForms.DetailsPageComponent,
    eShopLegacyWebForms.EditPageComponent,
    eShopLegacyWebForms.HomePageComponent,
    eShopLegacyWebForms.LogInPageComponent,
    eShopLegacyWebForms.SiteMasterMasterComponent,
  ],
  declarations: [
    eShopLegacyWebForms.CreatePageComponent,
    eShopLegacyWebForms.DeletePageComponent,
    eShopLegacyWebForms.DetailsPageComponent,
    eShopLegacyWebForms.EditPageComponent,
    eShopLegacyWebForms.HomePageComponent,
    eShopLegacyWebForms.LogInPageComponent,
    eShopLegacyWebForms.SiteMasterMasterComponent,
  ],
  bootstrap: [
    eShopLegacyWebForms.CreatePageComponent,
    eShopLegacyWebForms.DeletePageComponent,
    eShopLegacyWebForms.DetailsPageComponent,
    eShopLegacyWebForms.EditPageComponent,
    eShopLegacyWebForms.HomePageComponent,
    eShopLegacyWebForms.LogInPageComponent,
    eShopLegacyWebForms.SiteMasterMasterComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class EShopLegacyWebFormsModule { }

