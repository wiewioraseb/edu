import { Injectable } from '@angular/core';

type ComponentName = 'login-detail' | 'select-group' | 'add-avatar' | 'form-submit';

@Injectable({
  providedIn: 'root'
})
export class RedirectStateService {
  private stateMap = new Map<string, boolean>([
    ['login-detail', false],
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
