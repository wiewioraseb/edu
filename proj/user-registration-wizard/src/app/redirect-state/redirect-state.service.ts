import { Injectable } from '@angular/core';

export enum ComponentName {
  LoginDetail = 'login-detail',
  SelectGroup = 'select-group',
  AddAvatar = 'add-avatar',
  FormSubmit = 'form-submit'
}

@Injectable({
  providedIn: 'root'
})
export class RedirectStateService {
  private stateMap = new Map<string, boolean>([
    ['login-detail', true],
    ['select-group', false],
    ['add-avatar', false],
    ['form-submit', false]
  ]);

  constructor() { }

  canNavigate(componentName: ComponentName): boolean {
    return this.stateMap.get(componentName);
  }

  getAll(): Map<string, boolean> {
    return this.stateMap;
  }

  setNavigateState(componentName: ComponentName, state: boolean): void {
    this.stateMap.set(componentName, state);
  }
}
