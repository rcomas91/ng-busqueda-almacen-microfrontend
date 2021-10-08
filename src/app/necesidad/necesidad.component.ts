import { Component, OnInit, ViewChild } from "@angular/core";
import { MatSort, MatTable, MatTableDataSource } from "@angular/material";
import { Router } from "@angular/router";
import { IntervaloService } from "../intervalo/intervalo.service";
import { SomeModel } from "../winatm/SomeModel";
import { Necesidad } from "./necesidad";
import { NecesidadService } from "./necesidad.service";
@Component({
  selector: "app-necesidad",
  templateUrl: "./necesidad.component.html",
})
export class NecesidadComponent implements OnInit {
  @ViewChild(MatTable, { static: true }) table: MatTable<Necesidad>;
  @ViewChild(MatSort,{static:true}) sort: MatSort;

  necesidades: Necesidad[];
  necesidad: Necesidad;
  item: SomeModel;
  i:number=0;
  isLoading = true;

  // sum:number=this.intervaloService.intervalo.precioB+this.intervaloService.intervalo.precioC;
  constructor(
    private router: Router,
    private necesidadService: NecesidadService,
    public intervaloService: IntervaloService
  ) {}
  displayedColumns = [
  
    "codigo",
    "nombre",
    "nombrePozo",

    "UM",
    "cantidad",
    "existencia",
    "precioCup",
    "precioTotal",
    "utm_mov",
    "estado",
    
    "Borrar",
  ];
  dataSource: any;

  ngOnInit() {
    this.renderDataTable();
    console.log(this.intervaloService.intervalo);
  }
  delete(id: number) {
    if (confirm("Realmente desea cancelar?")) {
      this.necesidadService.delete(id).subscribe(
        (nec) => this.renderDataTable(),
        (error) => console.error(error)
      );
    }
  }

  cargarData() {
    this.necesidadService
      .getNecesidades()
      .subscribe(
        (necesidadesDesdesWS) => (this.necesidades = necesidadesDesdesWS)
      );
  }

  renderDataTable() {
    this.necesidadService.getNecesidades().subscribe(
      x => {
        this.isLoading = false;

        this.dataSource = new MatTableDataSource();
        console.log(this.intervaloService.intervalo);
        // this.dataSource.data = x.filter(art => art.intervaloId == this.intervaloService.intervalo.intervaloId)
        this.dataSource.data = x;
        this.dataSource.sort=this.sort;

        this.dataSource.data.forEach((item: Necesidad) => {
          // this.sum+=item.precioCUP*item.cantidad;
          // console.log(this.sum)
        });

        console.log(this.dataSource.data);
      },
      (error) => {
       this.isLoading = false;
        console.log("Ocurrió un error al consultar las necesidades!" + error);
      }
    );
  }

  cambiarEstado( nec: Necesidad) {
    console.log(nec);
    let estados = [
      "Pendiente a solicitar",
      "Pendiente de Oferta",
      "En Licitación",
      "Pendiente de contratación",
      "Pendiente de Carta de Crédito",
      "Pendiente de Fabricación",
      "Navegando",
    ];
      
      nec.estado = estados[this.i];
      this.i++;
      
      if(this.i==estados.length){
        this.i=0;
      }
    
    this.necesidadService.update(nec).subscribe(
      (int) => this.onSaveSuccess(),
      (error) => console.error(error)
    );
  }

  onSaveSuccess() {
    this.router.navigate(["/necesidades"]);
  }


}
