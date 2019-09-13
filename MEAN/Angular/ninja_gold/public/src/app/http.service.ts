import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {}

  newGame(){
    return this._http.post('/new',{});
  }
  updateGame(data){
    return this._http.put('/update',data);
  }
}
