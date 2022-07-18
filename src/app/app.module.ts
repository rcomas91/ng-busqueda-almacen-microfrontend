import { BrowserModule } from '@angular/platform-browser';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponentComponent } from './header-component/header-component.component';
import { FooterComponent } from './footer/footer.component';
import { ArticuloComponent } from './articulo/articulo.component';
import { ArticuloService } from './articulo/articulo.service';
import{RouterModule, Routes } from '@angular/router';
import{HttpClientModule, HttpClient} from '@angular/common/http';
import { NecesidadComponent } from './necesidad/necesidad.component';
import { NecesidadService } from './necesidad/necesidad.service';
import { FormComponent } from './necesidad/form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { PozoComponent } from './pozo/pozo.component';
import { PozoService } from './pozo/pozo.service';
import { MatSliderModule } from '@angular/material/slider';
import { MatAutocompleteModule, MatButtonModule, MatCardModule, MatCheckboxModule, MatChipsModule, MatDatepickerModule, MatDialogModule, MatExpansionModule, MatFormFieldModule, MatGridTile, MatIconModule, MatInputModule, MatMenuModule, MatNativeDateModule, MatPaginatorModule, MatProgressSpinnerModule, MatRadioModule, MatSort, MatSortModule, MatTableDataSource, MatTableModule, MatTabsModule, MatToolbarModule } from '@angular/material';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { IntervaloComponent } from './intervalo/intervalo.component';
import { PozoFormComponent } from './pozo/pozo-form.component';
import { IntervaloFormComponent } from './intervalo/intervalo-form.component';
import {MatGridListModule} from '@angular/material/grid-list';
import { WinatmComponent } from './winatm/winatm.component';
import { MatSelectModule } from '@angular/material/select';
import { ArticuloFormComponent } from './articulo/articulo-form.component';
import { ConstruccionService } from './pozo/construccion.service';
import { MatTableExporterModule } from 'mat-table-exporter';
import { ToastrModule } from 'ngx-toastr';
import { ArticuloPropioComponent } from './articulo-propio/articulo-propio.component';
import { ServiciosComponent } from './servicios/servicios.component';
import { ServiciosFormComponent } from './servicios/servicios-form.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ChartsModule, ThemeService } from 'ng2-charts';
import { NgCamisaComponentComponent } from './ng-camisa-component/ng-camisa-component.component';
import { LazyElementsModule,LazyElementsLoaderService } from '@angular-extensions/elements';



const routes:Routes=[
  {path:'',redirectTo:'/login',pathMatch:'full'},
  {path:'articulos',component:ArticuloComponent},
  {path:'articulos/form',component:ArticuloFormComponent},
  {path:'articulos/form/:id',component:ArticuloFormComponent},

  {path:'winatm',component:WinatmComponent},
  {path:'necesidades',component:NecesidadComponent},
  {path:'necesidades/form',component:FormComponent},
  {path:'necesidades/form/:id',component:FormComponent},


  {path:'pozos',component:PozoComponent},
  {path:'pozos/form',component:PozoFormComponent},
  {path:'pozos/form/:id',component:PozoFormComponent},



  {path:'servicios',component:ServiciosComponent},
  {path:'servicios/form',component:ServiciosFormComponent},
  {path:'servicios/form/:id',component:ServiciosFormComponent},


  {path:'articuloPropio/form',component:ArticuloPropioComponent},
  {path:'articuloPropio/form/:id',component:ArticuloPropioComponent},


  {path:'intervalos',component:IntervaloComponent},
  {path:'intervalos/form',component:IntervaloFormComponent},
  {path:'intervalos/form/:id',component:IntervaloFormComponent},


  { path: 'camisa', component: NgCamisaComponentComponent },

  { path: "", component: AppComponent, pathMatch: "full" },
  { path: "login", component: LoginComponent, pathMatch: "full" },
  // { path: "register", component: RegisterComponent, pathMatch: "full" }
]
@NgModule({
  schemas: [CUSTOM_ELEMENTS_SCHEMA],

    declarations: [

    AppComponent,
    HeaderComponentComponent,
    FooterComponent,
    ArticuloComponent,
    NecesidadComponent,
    FormComponent,

    PozoComponent,
    IntervaloComponent,
    PozoFormComponent,
    IntervaloFormComponent,
    WinatmComponent,
    ArticuloFormComponent,
    ArticuloPropioComponent,
    ServiciosComponent,
    ServiciosFormComponent,

    NgCamisaComponentComponent,
    LoginComponent,
    RegisterComponent,

  ],
  imports: [

    BrowserModule,
    HttpClientModule,
    FormsModule,

    LazyElementsModule,

    ToastrModule.forRoot({

    maxOpened:0,
    autoDismiss	:true,
    preventDuplicates: true,
    }
    ), // ToastrModule added

    AppRoutingModule,
    RouterModule.forRoot(routes),
    MatSortModule,
    MatGridListModule,

    MatSliderModule,
    MatToolbarModule,
    MatIconModule,
  MatButtonModule,
  MatExpansionModule,
  MatTabsModule,
  MatCardModule,
  ChartsModule,
  MatFormFieldModule,
  BrowserAnimationsModule,
  MatInputModule,
  MatDialogModule,
  MatTableModule,
  MatMenuModule,
  MatIconModule,
  MatProgressSpinnerModule,
  MatRadioModule,
  ReactiveFormsModule,
  MatDatepickerModule,
  MatNativeDateModule,
  MatSelectModule,
  MatPaginatorModule,
  MatIconModule,
  MatAutocompleteModule,
  MatTableExporterModule,
  MatChipsModule,
  MatCheckboxModule,

  ],
  exports: [RouterModule],
  providers: [ThemeService,ArticuloService,NecesidadService ,PozoService,LazyElementsLoaderService,ConstruccionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
