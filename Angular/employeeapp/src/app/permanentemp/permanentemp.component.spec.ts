import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PermanentempComponent } from './permanentemp.component';

describe('PermanentempComponent', () => {
  let component: PermanentempComponent;
  let fixture: ComponentFixture<PermanentempComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PermanentempComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PermanentempComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
