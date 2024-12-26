import { TestBed } from '@angular/core/testing';
import { CanDeactivateFn } from '@angular/router';

import { dguardGuard } from './dguard.guard';

describe('dguardGuard', () => {
  const executeGuard: CanDeactivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => dguardGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
