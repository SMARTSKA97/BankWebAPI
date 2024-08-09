import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Bank } from './bank.model';

@Injectable({
  providedIn: 'root',
})
export class BankService {
  private apiUrl = 'http://localhost:7249/api/banks';

  constructor(private http: HttpClient) {}

  getBanks(): Observable<Bank[]> {
    return this.http.get<Bank[]>(this.apiUrl);
  }
}
