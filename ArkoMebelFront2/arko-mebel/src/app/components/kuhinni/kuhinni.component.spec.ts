import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KuhinniComponent } from './kuhinni.component';

describe('KuhinniComponent', () => {
  let component: KuhinniComponent;
  let fixture: ComponentFixture<KuhinniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KuhinniComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KuhinniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
