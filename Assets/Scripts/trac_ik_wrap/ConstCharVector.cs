//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace IK {

public class ConstCharVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IList<string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConstCharVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConstCharVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConstCharVector() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          trac_ik_wrapPINVOKE.delete_ConstCharVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ConstCharVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public ConstCharVector(global::System.Collections.Generic.IEnumerable<string> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (string element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public string this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(string[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, string[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public string[] ToArray() {
    string[] array = new string[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator() {
    return new ConstCharVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ConstCharVectorEnumerator(this);
  }

  public ConstCharVectorEnumerator GetEnumerator() {
    return new ConstCharVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ConstCharVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<string>
  {
    private ConstCharVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ConstCharVectorEnumerator(ConstCharVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public string Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (string)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    trac_ik_wrapPINVOKE.ConstCharVector_Clear(swigCPtr);
  }

  public void Add(string x) {
    trac_ik_wrapPINVOKE.ConstCharVector_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = trac_ik_wrapPINVOKE.ConstCharVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = trac_ik_wrapPINVOKE.ConstCharVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    trac_ik_wrapPINVOKE.ConstCharVector_reserve(swigCPtr, n);
  }

  public ConstCharVector() : this(trac_ik_wrapPINVOKE.new_ConstCharVector__SWIG_0(), true) {
  }

  public ConstCharVector(ConstCharVector other) : this(trac_ik_wrapPINVOKE.new_ConstCharVector__SWIG_1(ConstCharVector.getCPtr(other)), true) {
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstCharVector(int capacity) : this(trac_ik_wrapPINVOKE.new_ConstCharVector__SWIG_2(capacity), true) {
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  private string getitemcopy(int index) {
    string ret = trac_ik_wrapPINVOKE.ConstCharVector_getitemcopy(swigCPtr, index);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string getitem(int index) {
    string ret = trac_ik_wrapPINVOKE.ConstCharVector_getitem(swigCPtr, index);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, string val) {
    trac_ik_wrapPINVOKE.ConstCharVector_setitem(swigCPtr, index, val);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(ConstCharVector values) {
    trac_ik_wrapPINVOKE.ConstCharVector_AddRange(swigCPtr, ConstCharVector.getCPtr(values));
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public ConstCharVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = trac_ik_wrapPINVOKE.ConstCharVector_GetRange(swigCPtr, index, count);
    ConstCharVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ConstCharVector(cPtr, true);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, string x) {
    trac_ik_wrapPINVOKE.ConstCharVector_Insert(swigCPtr, index, x);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, ConstCharVector values) {
    trac_ik_wrapPINVOKE.ConstCharVector_InsertRange(swigCPtr, index, ConstCharVector.getCPtr(values));
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    trac_ik_wrapPINVOKE.ConstCharVector_RemoveAt(swigCPtr, index);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    trac_ik_wrapPINVOKE.ConstCharVector_RemoveRange(swigCPtr, index, count);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ConstCharVector Repeat(string value, int count) {
    global::System.IntPtr cPtr = trac_ik_wrapPINVOKE.ConstCharVector_Repeat(value, count);
    ConstCharVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new ConstCharVector(cPtr, true);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    trac_ik_wrapPINVOKE.ConstCharVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    trac_ik_wrapPINVOKE.ConstCharVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, ConstCharVector values) {
    trac_ik_wrapPINVOKE.ConstCharVector_SetRange(swigCPtr, index, ConstCharVector.getCPtr(values));
    if (trac_ik_wrapPINVOKE.SWIGPendingException.Pending) throw trac_ik_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(string value) {
    bool ret = trac_ik_wrapPINVOKE.ConstCharVector_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(string value) {
    int ret = trac_ik_wrapPINVOKE.ConstCharVector_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(string value) {
    int ret = trac_ik_wrapPINVOKE.ConstCharVector_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(string value) {
    bool ret = trac_ik_wrapPINVOKE.ConstCharVector_Remove(swigCPtr, value);
    return ret;
  }

}

}
