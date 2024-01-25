import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MehmonxonaComponent } from './mehmonxona.component';

describe('MehmonxonaComponent', () => {
  let component: MehmonxonaComponent;
  let fixture: ComponentFixture<MehmonxonaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MehmonxonaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MehmonxonaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
