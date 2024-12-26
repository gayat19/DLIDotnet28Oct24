import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultantempComponent } from './consultantemp.component';

describe('ConsultantempComponent', () => {
  let component: ConsultantempComponent;
  let fixture: ComponentFixture<ConsultantempComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConsultantempComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConsultantempComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
