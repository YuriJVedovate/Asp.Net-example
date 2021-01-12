import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Candidatos } from '../models/Candidatos';
import { Candidato } from '../models/Candidato';
import { CandidatoCreateRequest } from '../models/request/CandidatoCreateRequest';

@Injectable({
  providedIn: 'root'
})
export class CandidatosService {
  
  constructor(private http: HttpClient) { }
  baseUrl = `${environment.mainUrl}/api/Candidato`;

  httpOptions ={
    headers: new HttpHeaders({
      'content-Type': 'application/json'
    })
  };

  public getAllCandidatos(): Observable<Candidatos>{
    return this.http.get<Candidatos>(`${this.baseUrl}`);
  }

  public postCandidato(candidatoRequest: CandidatoCreateRequest): Observable<CandidatoCreateRequest>{
    return this.http.post<CandidatoCreateRequest>(this.baseUrl, candidatoRequest, this.httpOptions);
  }

  public deleteCandidato(id: number): Observable<Candidato>{
    return this.http.delete<Candidato>(`${this.baseUrl}/${id}`);
  }
} 
