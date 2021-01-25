import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Partido } from '../models/Partido';
import { Partidos } from '../models/Partidos';
import { PartidoCreateRequest } from '../models/request/PartidoCreateRequest';

@Injectable({
  providedIn: 'root'
})
export class PartidosService {

  constructor(private http: HttpClient) { }
  baseUrl = `${environment.mainUrl}/api/Partido`;

  httpOptions ={
    headers: new HttpHeaders({
      'content-Type': 'application/json'
    })
  };

  public getAllPartidos(): Observable<Partidos> {
    return this.http.get<Partidos>(`${this.baseUrl}`);
  }

  public postPartido(partidoRequest : PartidoCreateRequest): Observable<PartidoCreateRequest> {
    return this.http.post<PartidoCreateRequest>(this.baseUrl, partidoRequest, this.httpOptions);
  }

  public deletePartido(id: number): Observable<Partido>{
    return this.http.delete<Partido>(`${this.baseUrl}/${id}`);
  }
}
