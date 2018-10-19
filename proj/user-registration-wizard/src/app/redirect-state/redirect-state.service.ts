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
    [ComponentName.LoginDetail, true],
    [ComponentName.SelectGroup, false],
    [ComponentName.AddAvatar, false],
    [ComponentName.FormSubmit, false]
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
