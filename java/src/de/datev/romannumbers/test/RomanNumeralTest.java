package de.datev.romannumbers.test;

import static org.junit.Assert.assertEquals;

import org.junit.Before;
import org.junit.Test;

import de.datev.romannumbers.RomanNumeral;

public class RomanNumeralTest {

	RomanNumeral rn;

	@Before
	public void before() {
		rn = new RomanNumeral();
	}

	@Test
	public void testOn1() {
		String res = rn.convertArabicToRomanNumeral(1);
		String exp = "I";
		assertEquals(exp, res);
	}

	@Test
	public void testOn5() {
		String res = rn.convertArabicToRomanNumeral(5);
		String exp = "V";
		assertEquals(exp, res);
	}

	@Test
	public void testOn10() {
		String res = rn.convertArabicToRomanNumeral(10);
		String exp = "X";
		assertEquals(exp, res);
	}

	@Test
	public void testOn50() {
		String res = rn.convertArabicToRomanNumeral(50);
		String exp = "L";
		assertEquals(exp, res);
	}

	@Test
	public void testOn100() {
		String res = rn.convertArabicToRomanNumeral(100);
		String exp = "C";
		assertEquals(exp, res);
	}

	@Test
	public void testOn500() {
		String res = rn.convertArabicToRomanNumeral(500);
		String exp = "D";
		assertEquals(exp, res);
	}

	@Test
	public void testOn1000() {
		String res = rn.convertArabicToRomanNumeral(1000);
		String exp = "M";
		assertEquals(exp, res);
	}

	@Test
	public void testOn11() {
		String res = rn.convertArabicToRomanNumeral(11);
		String exp = "XI";
		assertEquals(exp, res);
	}

	@Test
	public void testOn9() {
		String res = rn.convertArabicToRomanNumeral(9);
		String exp = "IX";
		assertEquals(exp, res);
	}

	@Test
	public void testOn16() {
		String res = rn.convertArabicToRomanNumeral(16);
		String exp = "XVI";
		assertEquals(exp, res);
	}

	@Test
	public void testOn1999() {
		String res = rn.convertArabicToRomanNumeral(1999);
		String exp = "MCMXCIX";
		assertEquals(exp, res);
	}

	@Test(expected = NumberFormatException.class)
	public void throwsIfNegative() {
		rn.convertArabicToRomanNumeral(-1);
	}

	@Test(expected = NumberFormatException.class)
	public void throwsIfTooLarge() {
		rn.convertArabicToRomanNumeral(4000);
	}

	@Test(expected = NumberFormatException.class)
	public void throwsIfZero() {
		rn.convertArabicToRomanNumeral(0);
	}

}
