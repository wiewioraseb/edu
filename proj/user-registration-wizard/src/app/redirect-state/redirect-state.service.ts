import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RedirectStateService {

  constructor() { }

  getState(): boolean {
    return true;
  }
}
